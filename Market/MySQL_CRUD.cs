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
        public MySQL_CRUD(string ConnectionString)
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();
            Console.WriteLine($"MySQL version : {connection.ServerVersion}");
        }
    }
}
