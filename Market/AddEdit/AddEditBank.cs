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
        public string OldIban;
        public int selectedID;
        public string command;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditBank()
        {
            InitializeComponent();
        }

        public AddEditBank(string cmd, string table, int id, string Iban = "")
        {
            InitializeComponent();

            selectedID = id;
            command = cmd;

            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Bank Wizerd";

            tableCol = Globals.GetColumnsIndex(table);
            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE BankIban = @BankIban AND UserID=@UserID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@UserID", selectedID);
                myPara.Add("@BankIban", Globals.RmSpace(Iban));
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    FullNameTB.Text = dr.IsDBNull(tableCol["FullNameOnwer"]) ? "" : dr.GetString("FullNameOnwer");
                    BankEnTB.Text = dr.IsDBNull(tableCol["BankNameEn"]) ? "" : dr.GetString("BankNameEn");
                    BankArTB.Text = dr.IsDBNull(tableCol["BankNameAR"]) ? "" : dr.GetString("BankNameAR");
                    IbanTB.Text = dr.IsDBNull(tableCol["BankIban"]) ? "" : dr.GetString("BankIban");
                    DateTB.Text = dr.IsDBNull(tableCol["ExpiryDate"]) ? "" : dr.GetString("ExpiryDate");

                    OldIban = dr.GetString("BankIban");

                }
            }


        }

        private void applyB_Click(object sender, EventArgs e)
        {

            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";

            if (FullNameTB.Text == "" || BankArTB.Text == "" || BankEnTB.Text == "" || IbanTB.Text == "" || DateTB.Text == "")
            {
                MessageBox.Show("Please fill all feilds");
                return;
            }

            if (command == "edit")
            {
                SQL = $"UPDATE {SQLtable} SET FullNameOnwer= @FullNameOnwer, BankNameEn= @BankNameEn, BankNameAR= @BankNameA, BankIban= @BankIban, ExpiryDate= @ExpiryDate WHERE BankIban = @BankIban AND UserID=@selectedID";

                myPara.Add("@BankIban", Globals.RmSpace(OldIban));
            }
            else if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "BankIban", Globals.RmSpace(IbanTB.Text)))
                {
                    MessageBox.Show("This Iban is alredy Exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (UserID, FullNameOnwer, BankNameEn, BankNameAR, BankIban, ExpiryDate) VALUES(@UserID, @FullNameOnwer, @BankNameEn, @BankNameAR, @BankIban, ExpiryDate);";

            }
            myPara.Add("@UserID", selectedID);
            myPara.Add("@FullNameOnwer", Globals.RmSpace(FullNameTB.Text));
            myPara.Add("@BankNameEn", Globals.RmSpace(BankEnTB.Text));
            myPara.Add("@BankNameAR", Globals.RmSpace(BankArTB.Text));
            myPara.Add("@BankIban", Globals.RmSpace(IbanTB.Text));
            myPara.Add("@ExpiryDate", Globals.RmSpace(DateTB.Text));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();

        }
        private void DateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;

            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || DateTB.Text.Length > 4)
            {
                e.Handled = true;
            }
            if (DateTB.Text.Length == 2)
            {
                DateTB.Text += "/";
                DateTB.SelectionStart = DateTB.Text.Length;
            }
        }
    }
}
