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
            using (StreamReader sr = new StreamReader(@"mysql.cfg"))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split(':');
                    if (keyvalue.Length == 2)
                    {
                        Globals.MySQLcfg.Add(keyvalue[0], keyvalue[1]);
                    }
                }
            }
            Globals.myCrud = new MySQL_CRUD();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OptionsForm());
        }


    }
}
