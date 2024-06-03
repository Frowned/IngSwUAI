using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace DAL.Helper
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            connectionString = GetConnectionString();
        }

        private string GetConnectionString()
        {
            // Retorna la cadena de conexión desde App.Config
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public int ExecuteNonQuery(string query, CommandType commandType = CommandType.Text, SqlParameter[] parameters = null, SqlTransaction transaction = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataSet ExecuteDataSet(string query, CommandType commandType = CommandType.Text, SqlParameter[] parameters = null, SqlTransaction transaction = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        command.CommandType = commandType;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }
    }

}
