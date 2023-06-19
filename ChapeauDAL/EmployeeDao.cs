using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAll()
        {
            string query = "SELECT id, name, hash, salt, role FROM Employee";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public Employee GetById(int id)
        {
            string query = $"SELECT id, name, hash, salt, role FROM Employee WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    employeeId = (int)row["id"],
                    name= (string)row["name"],
                    hash = (string)row["hash"],
                    salt = (string)row["salt"],
                    role = (Role)row["role"]
                };
                employees.Add(employee);
            }
            return employees;
        }
        private Employee ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Employee employee = new Employee()
            {
                employeeId = (int)row["id"],
                name = (string)row["name"],
                hash = (string)row["hash"],
                salt = (string)row["salt"],
                role = (Role)row["role"]
            };
            return employee;
        }
    }
}
