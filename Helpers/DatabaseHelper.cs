using MySql.Data.MySqlClient;
using dotenv.net;
using System;

namespace LmsApp.Helpers
{
    public class DatabaseHelper
    {
        private readonly String serverName = "";
        private readonly String port = "";
        private readonly String databaseName = "";
        private readonly String databaseUser = "";
        private readonly String databasePassword = "";

        private DatabaseHelper() {
            DotEnv.Load();
            serverName = Environment.GetEnvironmentVariable("SERVER_NAME") ?? "";
            port = Environment.GetEnvironmentVariable("SERVER_PORT") ?? "";
            databaseName = Environment.GetEnvironmentVariable("DB_NAME") ?? "";
            databaseUser = Environment.GetEnvironmentVariable("DB_USER") ?? "";
            databasePassword = Environment.GetEnvironmentVariable("DB_PASS") ?? "";
        }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        public MySqlConnection getConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
            var connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public MySqlDataReader getData(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, getConnection()))
                {
                    return command.ExecuteReader();
                }
            }
        }

        public int Update(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, getConnection()))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
