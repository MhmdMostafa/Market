using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Market
{
    class Globals
    {
        public static MySQL_CRUD myCrud = new MySQL_CRUD(@"mysql.cfg");
        public static int GetIdByString(string SqlTable, string StrCol, string str)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = $@"SELECT ID From {SqlTable} WHERE {StrCol} = @str";
            myPara.Add("@str", str); ;
            MySqlDataReader dr = myCrud.getDrPassSqlDic(SQL, myPara);
            dr.Read();
            return dr.GetInt32("ID");
        }

        public static string GetStringById(string columnString, string SqlTable, int Id)
        {
            string SQL = $@"SELECT {columnString} From {SqlTable} WHERE ID = {Id}";
            MySqlDataReader dr = myCrud.getDrPassSql(SQL);
            dr.Read();
            return dr.GetString(columnString);
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

        public static List<int> GetSelectedValues(DataGridView table)
        {
            List<int> Values = new List<int>();
            foreach (DataGridViewRow row in table.Rows)
            {

                DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);
                if (Convert.ToBoolean(checkBox.Value))
                {
                    DataGridViewTextBoxCell value = (row.Cells[1] as DataGridViewTextBoxCell);
                    Values.Add(Convert.ToInt32(value.Value));
                }
            }

            return Values;

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

        public static void Clean_SelectCbList(DataGridView Cbs, bool ched)
        {
            if (ched)
                foreach (DataGridViewRow row in Cbs.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);
                    checkBox.Value = true;
                }
            else
                foreach (DataGridViewRow row in Cbs.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);
                    checkBox.Value = false;
                }
        }

        public static bool CoutCbList(DataGridView Cbs)
        {
            int count = 0;
            foreach (DataGridViewRow row in Cbs.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);
                if (Convert.ToBoolean(checkBox.Value))
                {
                    count += 1;
                }
            }

            if (count > 1)
            {
                MessageBox.Show("Please Select One value");
                return false;
            }
            else if (count == 0)
            {
                MessageBox.Show("Please Select at least One value");
                return false;
            }

            else if (count == 1)
            {
                return true;
            }
            return false;

        }



        public static void DeleteValue(string table, string columnName, object value)
        {
            string SQL = $@"DELETE FROM {table} WHERE {columnName} = @value;";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@value", value);
            myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
        }

        public static bool ifExist(string table, string columnName, string value)
        {
            string SQL = $"SELECT * FROM {table} WHERE {columnName} = @value";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add($"@value", value);

            bool flag;
            using (MySqlDataReader dr = myCrud.getDrPassSqlDic(SQL, myPara))
                if (dr.HasRows)
                    flag = true;
                else
                    flag = false;

            return flag;
        }
        public static bool ifExist(string table, string columnName, string value, int ID)
        {
            string SQL = $@"SELECT * FROM {table} WHERE {columnName} = @value and ID!=@ID";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add($"@value", value);
            myPara.Add($"@ID", ID);
            bool flag;
            using (MySqlDataReader dr = myCrud.getDrPassSqlDic(SQL, myPara))
                if (dr.HasRows)
                    flag = true;
                else
                    flag = false;
            return flag;
        }

        public static string encrypt(string pass)
        {

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(pass));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();

        }


        public static string decrypt(string pass)
        {

            return "";
        }

    }
}
