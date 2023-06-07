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
            string query = "SELECT id, Employee_id, comment, paymentMethod, tip, payed FROM bill";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public Bill GetById(int id)
        {
            string query = $"SELECT id, Employee_id, comment, paymentMethod, tip, payed FROM bill WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();
            foreach (DataRow row in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    billId = (int)row["id"],
                    employeeId = (int)row["Employee_id"],
                    comment = (string)row["comment"],
                    paymentMethod = (PaymentMethod)row["paymentMethod"],
                    tip = (int)row["tip"],
                    payed = (bool)row["payed"]
                };
                bills.Add(bill);
            }
            return bills;
        }
        private Bill ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Bill bill = new Bill()
            {
                billId = (int)row["id"],
                employeeId = (int)row["Employee_id"],
                comment = (string)row["comment"],
                paymentMethod = (PaymentMethod)row["paymentMethod"],
                tip = (int)row["tip"],
                payed = (bool)row["payed"]
            };
            return bill;
        }
    }
}
