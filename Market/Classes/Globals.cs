using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Market
{
    class Globals
    {
        public static MySQL_CRUD myCrud = new MySQL_CRUD(@"mysql.cfg");
        public static int GetID(string columnID, string SqlTable, string StrCol, string str)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = $@"SELECT {columnID} From {SqlTable} WHERE {StrCol} = @str";
            myPara.Add("@str", str); ;
            MySqlDataReader dr = myCrud.getDrPassSqlDic(SQL, myPara);
            dr.Read();
            return int.Parse(dr.GetString(columnID));
        }
        public static string RmSpace(string name)
        {
            if (name.Length == 0 || name == null)
                return name;
            while (name.Last() == ' ')
                name = name.Substring(0, name.Length - 1);
            while (name[0] == ' ')
                name = name.Substring(1, name.Length - 1);
            return name;
        }

        public static Dictionary<string, int> GetColumnsIndex(string Table)
        {
            Dictionary<string, int> columns = new Dictionary<string, int>();
            int count = 0;
            using (MySqlDataReader dr = myCrud.getDrPassSql($@"SELECT * FROM {Table};"))
            {
                dr.Read();
                try
                {
                    while (true)
                    {
                        columns.Add(dr.GetName(count), count);
                        count += 1;
                    }
                }
                catch (Exception e)
                {

                }

            }
            return columns;
        }

        public static void Clean_SelectCbList(CheckedListBox Cbs, bool ched)
        {
            if (ched)
                for (int i = 0; i < Cbs.Items.Count; i++)
                {
                    Cbs.SetItemChecked(i, true);
                }
            else
                for (int i = 0; i < Cbs.Items.Count; i++)
                {
                    Cbs.SetItemChecked(i, false);
                }
        }

        public static bool CoutCbList(CheckedListBox Cbs)
        {
            if (Cbs.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please Select One value");
                return false;
            }
            else if (Cbs.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Select at least One value");
                return false;
            }

            else if (Cbs.CheckedItems.Count == 1)
            {
                return true;
            }
            return false;
        }

        public static void DeleteValue(string table, string columnName, string value)
        {
            string SQL = $@"DELETE FROM {table} WHERE {columnName} = @value;";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@value", value);
            myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
        }

        public static bool ifExist(string table, string columnName, string value)
        {
            string SQL = $"SELECT * FROM {table} WHERE @{columnName} = @value";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add($"@{columnName}", value);
            MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara);
            if (dr.Read())
                return true;
            else
                return false;
        }

    }
}
