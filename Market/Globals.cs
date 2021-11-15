using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Market
{
    class Globals
    {
        public static MySQL_CRUD myCrud = new MySQL_CRUD(@"mysql.cfg");
        public static int GetID(string SqlTable, string StrCol, string str, string columnID)
        {
            string SQL = $"SELECT {columnID} From {SqlTable} WHERE {StrCol} = {str}";
            MySqlDataReader dr = myCrud.getDrPassSql("SELECT * FROM continents;");
            dr.Read();
            return int.Parse(dr.GetString(columnID));
        }
    }
}
