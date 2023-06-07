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
            string query = "SELECT id, Table_id, dateTime FROM [Reservation]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public Reservation GetById(int id)
        {
            string query = $"SELECT @id, Table_id, dateTime FROM [Reservation] WHERE id = @id";
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
                Reservation reservation = new Reservation()
                {
                    reservationId = (int)row["id"],
                    tableId = (int)row["Table_id"],
                    date = (DateTime)row["datetime"],
                };
            }
            return reservations;
        }
        private Reservation ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Reservation reservation = new Reservation()
            {
                reservationId = (int)row["id"],
                tableId = (int)row["Table_id"],
                date = (DateTime)row["datetime"],
            };
            return reservation;
        }
    }
}
