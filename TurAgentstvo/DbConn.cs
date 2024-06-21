using System;
using MySql.Data.MySqlClient;

namespace TurAgentstvo
{
    internal class DbConn
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "tur_agentstvo";
            string username = "root";
            string password = "";
            String connString = "Server=" + host + ";Database=" + database
            + ";port=" + port + ";User Id=" + username + ";password=" +
            password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
