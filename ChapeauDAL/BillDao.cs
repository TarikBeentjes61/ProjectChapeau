using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public List<Bill> GetAll()
        {
            string query = 
                "SELECT B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed, " +
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
                $"SELECT B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed, " +
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

        public void UpdateBill(int id, string comment, int paymentMethod, double tip, double payed)
        {
            string query = $"UPDATE BILL SET [comment] = @comment, [paymentMethod] = @paymentMethod, [tip] = @tip, [payed] = @payed WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
                new SqlParameter("@comment", comment ),
                new SqlParameter("@paymentMethod", paymentMethod ),
                new SqlParameter("@tip", tip ),
                new SqlParameter("@payed", payed ),
             };
            ExecuteEditQuery(query, sqlParameters);
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
                comment = (string)row["comment"],
                paymentMethod = (PaymentMethod)row["paymentMethod"],
                tip = (int)row["tip"],
            };
        }
    }
}
