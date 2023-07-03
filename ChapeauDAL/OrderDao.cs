using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAll()
        {
            string query = 
                "SELECT O.id AS O_id, O.[dateTime], O.[status], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM [Order] AS O " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN Employee AS E ON O.Employee_id = E.id " +
                "JOIN Bill AS B ON O.Bill_id = B.id";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public List<Order> GetAllByState(OrderStatus status)
        {
            string query = 
                "SELECT O.id AS O_id, O.[dateTime], O.[status], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM [Order] AS O " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN Employee AS E ON O.Employee_id = E.id " +
                "JOIN Bill AS B ON O.Bill_id = B.id " +
                "WHERE O.[status] = @status";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@status", (int)status),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Order GetById(int id)
        {
            string query = "SELECT O.id AS O_id, O.[dateTime], O.[status], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM [Order] AS O " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN Employee AS E ON O.Employee_id = E.id " +
                "JOIN Bill AS B ON O.Bill_id = B.id " +
                "WHERE O.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public int AddOrder(int tableId, int employeeId, int billId, DateTime dateTime, OrderStatus status)
        {
            string query = "INSERT INTO [Order] OUTPUT INSERTED.id VALUES (@Table_id, @Employee_id, @Bill_id, @dateTime, @status)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Table_id", tableId),
                new SqlParameter("@Employee_id", employeeId),
                new SqlParameter("@Bill_id", billId),
                new SqlParameter("@dateTime", dateTime),
                new SqlParameter("@status", (int)status),
            };
            return ExecuteInsertQuery(query, sqlParameters);
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow row in dataTable.Rows)
            {
                Order order = CreateOrderFromRow(row);
                orders.Add(order);
            }
            return orders;
        }
        private Order ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return CreateOrderFromRow(row);
        }
        private static Order CreateOrderFromRow(DataRow row)
        {
            Table table = new Table()
            {
                tableId = (int)row["T_id"],
                status = (TableStatus)row["status"]
            };
            Employee employee = new Employee()
            {
                employeeId = (int)row["E_id"],
                name = (string)row["name"],
                hash = (string)row["hash"],
                salt = (string)row["salt"],
                role = (Role)row["role"]
            };
            Bill bill = new Bill()
            {
                billId = (int)row["B_id"],
                table = table,
                employee = employee,
                comment = (string)row["comment"],
                paymentMethod = (PaymentMethod)row["paymentMethod"],
                tip = (int)row["tip"],
                payed = (int)row["payed"],
            };
            return new Order()
            {
                id = (int)row["O_id"],
                table = table,
                employee = employee,
                bill = bill,
                date = (DateTime)row["dateTime"],
                status = (OrderStatus)row["status"]
            };
        }
    }
}
