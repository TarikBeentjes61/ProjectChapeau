using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class ReservationDao : BaseDao
    {
        public List<Reservation> GetAll()
        {
            string query = "SELECT R.id AS R_id, R.[dateTime], R.[name], " +
                "T.id AS T_id, T.[status] " +
                "FROM Reservation AS R " +
                "JOIN [Table] AS T ON R.Table_id = T.id";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public Reservation GetById(int id)
        {
            string query = "SELECT R.id AS R_id, R.[dateTime], R.[name], " +
                "T.id AS T_id, T.[status] " +
                "FROM Reservation AS R " +
                "JOIN [Table] AS T ON R.Table_id = T.id " +
                "WHERE R.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Reservation> ReadTables(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();
            foreach (DataRow row in dataTable.Rows)
            {
                Reservation reservation = CreateReservationFromRow(row);
                reservations.Add(reservation);
            }
            return reservations;
        }
        private Reservation ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return CreateReservationFromRow(row);
        }
        private Reservation CreateReservationFromRow(DataRow row)
        {
            Table table = new Table()
            {
                tableId = (int)row["T_id"],
                status = (TableStatus)row["status"]
            };
            return new Reservation()
            {
                table = table,
                name = (string)row["name"],
                date = (DateTime)row["dateTime"],
            };
        }
    }
}
