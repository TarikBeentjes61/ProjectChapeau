using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public Employee GetById(int id)
        {
            string query = $"SELECT id, name, hash, salt, role FROM Employee WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private Employee ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return CreateEmployeeFromRow(row);
        }
        private Employee CreateEmployeeFromRow(DataRow row)
        {
            return new Employee()
            {
                employeeId = (int)row["id"],
                name = (string)row["name"],
                hash = (string)row["hash"],
                salt = (string)row["salt"],
                role = (Role)row["role"]
            };
        }
    }
}
