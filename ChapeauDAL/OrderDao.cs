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
                username = (string)row["username"],
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
                payed = (bool)row["payed"],
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
