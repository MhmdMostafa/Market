using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class OptionsForm : Form
    {
        protected override void OnClosed(EventArgs e)
        {
            MainForm.FlagOpendWindow = false;
        }
        public OptionsForm()
        {
            InitializeComponent();
        }
        private MainForm MainWindow = null;
        public OptionsForm(Form MainWindowpar)
        {
            MainWindow = MainWindowpar as MainForm;
            InitializeComponent();
            HostcfgTB.Text = MySQL_CRUD.MySQLcfg["Host"];
            UsercfgTB.Text = MySQL_CRUD.MySQLcfg["User"];
            PasswordcfgTB.Text = MySQL_CRUD.MySQLcfg["Password"];
            DatabasecfgTB.Text = MySQL_CRUD.MySQLcfg["DataBase"];
        }
        

    }
}
