using Microsoft.Extensions.Hosting;
using MySqlConnector;

namespace DemoAPIv1.Connection
{
    public class Connect
    {

        static string host = "localhost";
        static int port = 3306;
        static string database = "WebAPICSharp";
        static string username = "root";
        static string password = "";

        public static MySqlConnection getConnection()
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

           
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

    }
}
