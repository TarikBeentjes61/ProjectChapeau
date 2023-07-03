using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public List<Bill> GetAll()
        {
            string query =
                "SELECT B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed, B.dateTime, B.billPrice, " +
                "E.id AS E_id, E.[username], E.[name], E.[hash], E.salt, E.[role], " +
                "T.id AS T_id, T.[status] " +
                "FROM Bill AS B " +
                "JOIN Employee AS E ON B.Employee_id = E.id " +
                "JOIN [Table] AS T ON B.Table_id = T.id";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public Bill GetById(int id)
        {
            string query =
                $"SELECT B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed, B.dateTime, B.billPrice, " +
                "E.id AS E_id, E.[username], E.[name], E.[hash], E.salt, E.[role], " +
                "T.id AS T_id, T.[status] " +
                "FROM Bill AS B " +
                "JOIN Employee AS E ON B.Employee_id = E.id " +
                "JOIN [Table] AS T ON B.Table_id = T.id " +
                "WHERE B.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public Bill CheckBill(Table table)
        {
            string query = "SELECT id, Employee_Id, table_Id, comment, paymentMethod, tip, payed, dateTime, billPrice FROM Bill WHERE table_Id = @Table_id AND payed = 1";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@Table_id", table.tableId),
             };
            Bill bill = ReadSingle(ExecuteSelectQuery(query, sqlParameters));

            if (bill == null)
            {
                return bill;
            }
            else
            {
                return null;
            }
        }
        public int CreateBill(Table table, Employee employee, string comment, int paymentMethod, double tip, bool payed, DateTime dateTime, double billPrice)
        {
            string query = "INSERT INTO Bill OUTPUT INSERTED.id VALUES (@Employee_Id, @Table_Id, @comment, @paymentMethod, @tip, @payed, @dateTime, @billPrice)";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                     new SqlParameter("@Employee_Id", employee.employeeId),
                     new SqlParameter("@Table_Id", table.tableId),
                     new SqlParameter("@comment", comment ),
                     new SqlParameter("@paymentMethod", paymentMethod ),
                     new SqlParameter("@tip", tip ),
                     new SqlParameter("@payed", payed ),
                     new SqlParameter("@dateTime", dateTime),
                     new SqlParameter("@billPrice", billPrice ),
             };
            return ExecuteInsertQuery(query, sqlParameters);
        }

        public void UpdateBill(int id, string comment, int paymentMethod, double tip, bool payed, DateTime dateTime, double billPrice) 
        { 
            string query = $"UPDATE BILL SET [comment] = @comment, [paymentMethod] = @paymentMethod, [tip] = @tip, [payed] = @payed WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
                new SqlParameter("@comment", comment ),
                new SqlParameter("@paymentMethod", paymentMethod ),
                new SqlParameter("@tip", tip ),
                new SqlParameter("@payed", payed ),
                new SqlParameter("@dateTime", dateTime ),
                new SqlParameter("@billPrice", billPrice ),
             };
            ExecuteEditQuery(query, sqlParameters);
        }
        public Bill GetBillByTableId(int tableId)
        {
            string query =
                $"SELECT B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed, " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
                "T.id AS T_id, T.[status] " +
                "FROM Bill AS B " +
                "JOIN Employee AS E ON B.Employee_id = E.id " +
                "JOIN [Table] AS T ON B.Table_id = T.id " +
                "WHERE T.id = @Table_id AND payed = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@Table_id", tableId),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();
            foreach (DataRow row in dataTable.Rows)
            {
                Bill bill = CreateBillFromRow(row);
                bills.Add(bill);
            }
            return bills;
        }
        private Bill ReadSingle(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dataTable.Rows[0];
            Bill bill = CreateBillFromRow(row);
            return bill;
        }

        private Bill CreateBillFromRow(DataRow row)
        {
            Table table = new Table()
            {
                tableId = (int)row["T_id"],
                status = (TableStatus)row["status"]
            };
            Employee employee_ = new Employee()
            {
                employeeId = (int)row["E_id"],
                username = (string)row["username"],
                name = (string)row["name"],
                hash = (string)row["hash"],
                salt = (string)row["salt"],
                role = (Role)row["role"]
            };
            return new Bill()
            {
                table = table,
                employee = employee_,
                billId = (int)row["B_id"],
                comment = (string)row["comment"],
                paymentMethod = (PaymentMethod)row["paymentMethod"],
                tip = (int)row["tip"],
                payed = (bool)row["payed"],
                dateTime = (DateTime)row["dateTime"],
                billPrice = Convert.ToDouble(row["billPrice"]),
            };
        }
    }
}
