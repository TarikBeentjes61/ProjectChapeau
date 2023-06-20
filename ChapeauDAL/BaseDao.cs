using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ChapeauDAL
{
    public abstract class BaseDao
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        public BaseDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chapeau"].ConnectionString);
            adapter = new SqlDataAdapter();

        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);

            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                //Print.ErrorLog(e);
                throw e;

            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw e;
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
        /* For Insert Queries */
        protected int ExecuteInsertQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            int id = 0;
            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                id = (int)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw e;
            }
            finally
            {
                CloseConnection();
            }
            return id;
        }
    }
}
