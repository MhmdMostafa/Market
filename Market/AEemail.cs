using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Market
{
    public partial class AEemail : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable;
        public string email;
        public AEemail()
        {
            InitializeComponent();
        }

        public AEemail(string table, string e)
        {
            InitializeComponent();
            SQLtable = table;
            email = e;
            EmailTB.Text = email;

        }

        private void applyB_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = $"UPDATE {SQLtable} SET EmailAddress= @EmailAddressNew WHERE EmailAddress = @EmailAddressOld";


            DialogResult d = MessageBox.Show("are you shure", "delete", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                myPara.Add("@EmailAddressNew", Globals.RmSpace(EmailTB.Text));
                myPara.Add("@EmailAddressOld", Globals.RmSpace(email));
                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                this.Close();
            }
        }
    }
}
