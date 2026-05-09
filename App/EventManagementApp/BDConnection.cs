using System.Data.SqlClient;

namespace EventManagementApp
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=Salma;Database=EventManagementDB;Integrated Security=True;";
       

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
