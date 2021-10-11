using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
namespace Market
{
    class MySQL_CRUD
    {
        public static string ConnectionString;
        public MySQL_CRUD(string MySQLcfgPath)
        {
            //cfg file must be like:
            //Host:****
            //User:****
            //Password:****
            //DataBase:****
            Dictionary<string, string> MySQLcfg = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(@MySQLcfgPath))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split(':');
                    if (keyvalue.Length == 2)
                    {
                        MySQLcfg.Add(keyvalue[0], keyvalue[1]);
                    }
                }
            }
            ConnectionString = string.Format(@"server={0};userid={1};password={2};database={3}", MySQLcfg["Host"], MySQLcfg["User"], MySQLcfg["Password"], MySQLcfg["DataBase"]);
        }

        public MySqlDataReader getDrPassSql(string mySql)
        {
            MySqlDataReader dr;
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(@mySql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            return dr;
        }

        public MySqlDataReader getDrPassSqlDic(string mySql, Dictionary<string, object> formValues)
        {
            MySqlDataReader dr;
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(mySql, con);
            foreach (KeyValuePair<string, object> p in formValues)
            {
                cmd.Parameters.AddWithValue(p.Key, p.Value);
            }
            con.Open();
            dr = cmd.ExecuteReader(CommandBehavior.Default);
            return dr;
        }

        public DataSet getDsPassSql(string mySql)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(mySql, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            using (con)
            {
                con.Open();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet getDsPassSqlDic(string mySql, Dictionary<string, object> formValues)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(mySql, con);
            foreach (KeyValuePair<string, object> p in formValues)
            {
                cmd.Parameters.AddWithValue(p.Key, p.Value);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            using (con)
            {
                con.Open();
                da.Fill(ds);
                return ds;
            }
        }

        public DataTable getDtPassSql(string mySql)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(mySql, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            using (con)
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public DataTable getDtPassSqlDic(string mySql, Dictionary<string, object> formValues)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(mySql, con);
            foreach (KeyValuePair<string, object> p in formValues)
            {
                cmd.Parameters.AddWithValue(p.Key, p.Value);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            using (con)
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public int InsertUpdateDeleteViaSqlDic(string sqlStatement, Dictionary<string, object> InputParaList)
        {
            int rowAffected;
            try
            {
                using (MySqlConnection cn = new MySqlConnection(ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sqlStatement, cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        foreach (KeyValuePair<string, object> p in InputParaList)
                        {
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                        }
                        using (cn)
                        {
                            cn.Open();
                            rowAffected = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            return rowAffected;
        }
    }
}
