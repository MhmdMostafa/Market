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
    public partial class AddEditBank : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable;
        public int UserID;
        public int BankID;
        public string command;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditBank()
        {
            InitializeComponent();
        }

        public AddEditBank(string cmd, string table, int User_Id, int bank_ID = 0)
        {
            InitializeComponent();
            string[] date;
            UserID = User_Id;
            command = cmd;
            BankID = bank_ID;
            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Bank Wizerd";

            tableCol = Globals.GetColumnsIndex(table);
            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE ID = @ID AND UserID=@UserID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@UserID", UserID);
                myPara.Add("@ID", BankID);
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    date = dr.GetString("ExpiryDate").Split('/');
                    MessageBox.Show(date.Length.ToString() + $"\n{date[0]}\n{date[1]}\n{date[2]}");
                    FullNameTB.Text = dr.IsDBNull(tableCol["FullNameOwner"]) ? "" : dr.GetString("FullNameOwner");
                    BankEnTB.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    BankArTB.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    IbanTB.Text = dr.IsDBNull(tableCol["Iban"]) ? "" : dr.GetString("Iban");
                    comboBox1.SelectedItem = date[1];
                    comboBox2.SelectedItem = (int.Parse(date[2].Split(' ')[0]) - 2000).ToString(); ;


                }
            }


        }

        private void applyB_Click(object sender, EventArgs e)
        {

            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";
            Globals.CleanTB(this.Controls);
            if (FullNameTB.Text == "" || BankArTB.Text == "" || BankEnTB.Text == "" || IbanTB.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill all feilds");
                return;
            }

            if (command == "edit")
            {
                if (Globals.ifExist(SQLtable, "Iban", IbanTB.Text, BankID))
                {
                    MessageBox.Show("This Iban is alredy Exist");
                    return;
                }
                SQL = $"UPDATE {SQLtable} SET FullNameOnwer= @FullNameOwner, NameEn= @NameEn, NameAr= @BankNameA, Iban= @Iban, ExpiryDate= STR_TO_DATE(concat('1-',@ExpiryDate), '%d-%m-%y') WHERE ID = @ID AND UserID=@UserID";

                myPara.Add("@ID", BankID);
            }
            else if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "Iban", IbanTB.Text))
                {
                    MessageBox.Show("This Iban is alredy Exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (UserID, FullNameOwner, NameEn, NameAr, Iban, ExpiryDate) VALUES(@UserID, @FullNameOwner, @NameEn, @NameAr, @Iban, STR_TO_DATE(concat('1-',@ExpiryDate), '%d-%m-%y'));";

            }
            myPara.Add("@UserID", UserID);
            myPara.Add("@FullNameOwner", FullNameTB.Text);
            myPara.Add("@NameEn", BankEnTB.Text);
            myPara.Add("@NameAr", BankArTB.Text);
            myPara.Add("@Iban", IbanTB.Text);
            myPara.Add("@ExpiryDate", (comboBox1.Text + "-" + comboBox2.Text));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();

        }


        private void IbanTB_keyPress(object sender, KeyPressEventArgs e)
        {

            if (IbanTB.Text.Length > 23 && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

    }
}
