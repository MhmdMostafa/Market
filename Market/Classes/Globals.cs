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
        public static int GetID(string columnID, string SqlTable, string StrCol, string str )
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@str", str);;
            string SQL = $@"SELECT {columnID} From {SqlTable} WHERE {StrCol} = @str";
            MySqlDataReader dr = myCrud.getDrPassSqlDic(SQL,myPara);
            dr.Read();
            return int.Parse(dr.GetString(columnID));
        }
        public static string RmSpace(string name)
        {
            if (name.Length == 0)
                return name;
            while (name.Last() == ' ')
                name = name.Substring(0, name.Length - 1);
            while (name[0] == ' ')
                name = name.Substring(1, name.Length - 1);
            return name;
        }

        public static Dictionary<string,int> GetColumnsIndex(string Table)
        {
            Dictionary<string, int> columns = new Dictionary<string, int>();
            int count = -1;
            using (MySqlDataReader dr = myCrud.getDrPassSql($@"SELECT * FROM {Table};"))
            {
                dr.Read();
                try
                {
                    while (true)
                    {
                        count += 1;
                        columns.Add(dr.GetName(count), count);
                    }
                }
                catch (Exception e)
                {

                }
                
            }
            return columns;
        }
    }
}
