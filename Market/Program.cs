using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Market
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            using (StreamReader sr = new StreamReader(@"MySQL.cfg"))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split(':');
                    if (keyvalue.Length == 2)
                    {
                        MySQL_CRUD.MySQLcfg.Add(keyvalue[0], keyvalue[1]);
                    }
                }
            }
            MySQL_CRUD.ConnectionString = string.Format(@"server={0};userid={1};password={2};database={3}", MySQL_CRUD.MySQLcfg["Host"], MySQL_CRUD.MySQLcfg["User"], MySQL_CRUD.MySQLcfg["Password"], MySQL_CRUD.MySQLcfg["DataBase"]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
