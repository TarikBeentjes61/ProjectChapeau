using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAll()
        {
            string query = "SELECT id, status FROM [Table]";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public void UpdateById(int id, int status)
        {
            string query = "UPDATE [Table] SET [status] = @status WHERE id = @id ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@status", status),
                new SqlParameter("@id", id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow row in dataTable.Rows)
            {
                Table table = CreateTableFromRow(row);
                tables.Add(table);
            }
            return tables;
        }
        private Table CreateTableFromRow(DataRow row)
        {
            return new Table()
            {
                tableId = (int)row["id"],
                status = (TableStatus)row["status"]
            };
        }
    }
}
