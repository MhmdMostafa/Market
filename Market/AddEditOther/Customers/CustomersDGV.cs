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
    public partial class CustomersDGV : MaterialSkin.Controls.MaterialForm
    {
        public CustomersDGV()
        {
            InitializeComponent();
            Text = "Custmers";
            refresh();

        }

        private void AddB_Click(object sender, EventArgs e)
        {
            MainCustomer window = new MainCustomer("add");
            window.ShowDialog();
            refresh();
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(CUDGV);
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

            MainCustomer window = new MainCustomer("edit", selectedValues[0]);
            window.ShowDialog();
            refresh();
        }

        private void SelectAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCb.Checked)
                Globals.Clean_SelectCbList(CUDGV, true);
            else
                Globals.Clean_SelectCbList(CUDGV, false);
        }

        public void refresh()
        {
            string SQL = $"SELECT customers.ID, UserName, customers.NameEn, customers.NameAr, BirthDate, NationalNumber, customer_groups.NameEn as GroupID, gender.NameEn as Gender  FROM customers INNER JOIN gender ON customers.GenderID=gender.ID INNER JOIN customer_groups ON customers.CustomerGroupID=customer_groups.ID;";
            CUDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }
    }
}
