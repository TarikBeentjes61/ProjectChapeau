﻿using ChapeauModel;
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
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
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
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role], " +
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
        //public int CheckAndCreateBill(int billId, Employee employee, Table table, string comment, int paymentMethod, double tip, int payed)
        //{
        //    string checkQuery = "SELECT COUNT(*) FROM Bills WHERE BillID = @BillID";
        //    string insertQuery = "INSERT INTO Bills (BillID, Employee_Id, Table_Id, comment, paymentMethod, tip, payed) OUTPUT INSERTED.id VALUES (@BillID, @Employee_Id, @Table_Id, @comment, @paymentMethod, @tip, @payed)";
        //    //string query = "INSERT INTO Bill OUTPUT INSERTED.id VALUES (@billId @Employee_Id, @Table_Id, @comment, @paymentMethod, @tip, @payed)";

        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@BillID", billId),
        //    };

        //    ExecuteInsertQuery(checkQuery, sqlParameters);
        //}
        public int CheckAndCreateBill(int id, Employee employee, Table table, string comment, int paymentMethod, double tip, int payed)
        {
            string query = "INSERT INTO Bill OUTPUT INSERTED.id VALUES (@billId @Employee_Id, @Table_Id, @comment, @paymentMethod, @tip, @payed)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Employee_id", employee.employeeId),
                new SqlParameter("@Table_id", table.tableId),
                new SqlParameter("@comment", comment ),
                new SqlParameter("@paymentMethod", paymentMethod ),
                new SqlParameter("@tip", tip ),
                new SqlParameter("@payed", payed ),
            };
            return ExecuteInsertQuery(query, sqlParameters);
        }
        public void UpdateBill(int id, string comment, int paymentMethod, double tip, int payed)
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
            };
        }
    }
}
