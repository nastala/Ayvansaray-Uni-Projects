using System.Data.SqlClient;
using System.Configuration;

namespace NorthWind.ORM
{
    public class Tools
    {
        private static SqlConnection _connection;
        internal static SqlConnection Connection => _connection ?? (_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindLocalConnection"].ConnectionString));

        public static bool ExecuteNonQuery(SqlCommand sqlCommand)
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            bool result = sqlCommand.ExecuteNonQuery() > 0;
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
            return result;
        }
    }
}
