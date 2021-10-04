using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Market
{
    class MySQL_CRUD
    {
        public static Dictionary<string, string> MySQLcfg = new Dictionary<string, string>();
        public static string ConnectionString;
        public MySQL_CRUD()
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();
            Console.WriteLine($"MySQL version : {connection.ServerVersion}");
        }
    }
}
