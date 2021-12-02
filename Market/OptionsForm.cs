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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            RefreshTap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@CommercialRegister", CommercialRegisterTb.Text);
            myPara.Add("@TaxNumber", TaxNumberTb.Text);
            myPara.Add("@ContactNumber", ContactNumberTb.Text);
            myPara.Add("@NameEn", NameEnTb.Text);
            myPara.Add("@NameAr", NameArTb.Text);
            myPara.Add("@VatValue", (float)VATTb.Value);

            Globals.myCrud.InsertUpdateDeleteViaSqlDic("UPDATE main_info SET CommercialRegister=@CommercialRegister, TaxNumber=@TaxNumber, ContactNumber=@ContactNumber, NameEn=@NameEn, NameAr=@NameAr, VatValue=@VatValue", myPara);

            this.Close();
        }

        private void AddUserB_Click(object sender, EventArgs e)
        {
            EmpsDGV window = new EmpsDGV();
            window.ShowDialog();
            RefreshTap();
        }

        public void RefreshTap()
        {
            switch (TabControl.SelectedTab.Text)
            {
                case "MySQL":
                    HostcfgTB.Text = Globals.MySQLcfg["Host"];
                    UsercfgTB.Text = Globals.MySQLcfg["User"];
                    PasswordcfgTB.Text = Globals.MySQLcfg["Password"];
                    DatabasecfgTB.Text = Globals.MySQLcfg["DataBase"];
                    break;
                case "Administration":
                    UsersDGV.DataSource = Globals.myCrud.getDtPassSql("SELECT ID, UserName FROM employees;");
                    break;
                case "Main Info":
                    using(MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM main_info;"))
                    {
                        dr.Read();
                        CommercialRegisterTb.Text = dr.GetString("CommercialRegister");
                        TaxNumberTb.Text = dr.GetString("TaxNumber");
                        ContactNumberTb.Text = dr.GetString("ContactNumber");
                        NameEnTb.Text = dr.GetString("NameEn");
                        NameArTb.Text = dr.GetString("NameAr");
                        VATTb.Value = (decimal)dr.GetFloat("VatValue");

                    }
                    break;
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTap();
        }

        private void EditUserB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(UsersDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            MainEmp window = new MainEmp("edit", selectedValues[0]);
            window.ShowDialog();
            RefreshTap();
        }
    }
}
