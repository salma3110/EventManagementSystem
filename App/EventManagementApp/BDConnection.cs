using System.Data.SqlClient;

namespace EventManagementApp
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=localhost;Database=EventManagementDB;Integrated Security=True;";
       

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
