using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class DatabaseConnection
    {
        private static readonly SqlConnection _sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        private static readonly SqlCommand _sqlCommand = new SqlCommand("", _sqlConnection);

        public static SqlConnection SqlConnection => _sqlConnection;

        public static void OpenConnection()
        {
            _sqlConnection.Open();
        }
        public static void CloseConnection()
        {
            _sqlConnection.Close();
        }
        public static IEnumerable<T> GetValues<T>(string query)
        {
            _sqlCommand.CommandText = query;
            OpenConnection();
            using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
            {
                while(dataReader.Read() == true)
                {
                    yield return (T)dataReader[0];
                }
            }
            CloseConnection();
        }
    }
}
