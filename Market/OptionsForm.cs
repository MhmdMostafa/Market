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
        public OptionsForm()
        {
            InitializeComponent();
        }
        public OptionsForm(Form MainWindowpar)
        {
            InitializeComponent();
            HostcfgTB.Text = MySQL_CRUD.MySQLcfg["Host"];
            UsercfgTB.Text = MySQL_CRUD.MySQLcfg["User"];
            PasswordcfgTB.Text = MySQL_CRUD.MySQLcfg["Password"];
            DatabasecfgTB.Text = MySQL_CRUD.MySQLcfg["DataBase"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddUserB_Click(object sender, EventArgs e)
        {
        }
    }
}
