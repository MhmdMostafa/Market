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
    public partial class AddEditAddress : MaterialSkin.Controls.MaterialForm
    {

        public string SQLtable;
        public string[] OldInfo = new string[6];
        public int selectedID;
        public string command;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditAddress()
        {
            InitializeComponent();
        }

        public AddEditAddress(string cmd, string table, int id, string Iban = "")
        {
            InitializeComponent();

            selectedID = id;
            command = cmd;

            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Wizerd";

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
                    DistrictTB.Text = dr.IsDBNull(tableCol["BankNameEn"]) ? "" : dr.GetString("BankNameEn");
                    StreetTB.Text = dr.IsDBNull(tableCol["BankNameAR"]) ? "" : dr.GetString("BankNameAR");
                    IbanTB.Text = dr.IsDBNull(tableCol["BankIban"]) ? "" : dr.GetString("BankIban");
                    DateTB.Text = dr.IsDBNull(tableCol["ExpiryDate"]) ? "" : dr.GetString("ExpiryDate");
                    OldInfo[0] = dr.GetString("FullNameOnwer");
                    OldInfo[1] = dr.GetString("BankNameEn");
                    OldInfo[2] = dr.GetString("BankNameAR");
                    OldInfo[3] = dr.GetString("BankIban");
                    OldInfo[4] = dr.GetString("ExpiryDate");

                }
            }
        }
    }
}
