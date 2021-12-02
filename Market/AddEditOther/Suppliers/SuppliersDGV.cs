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
    public partial class SuppliersDGV : MaterialSkin.Controls.MaterialForm
    {

        public SuppliersDGV()
        {
            InitializeComponent();
            refreshTap();
            Text = "Suppliers";
        }

        private void refreshTap()
        {
            dataGridView.DataSource = Globals.myCrud.getDtPassSql($@"SELECT * FROM suppliers;");
        }


        private void AddBT_Click(object sender, EventArgs e)
        {

            MainSupplier window = new MainSupplier("add");
            window.ShowDialog();
            refreshTap();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(dataGridView);
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

            MainSupplier window = new MainSupplier("edit", selectedValues[0]);
            window.ShowDialog();
            refreshTap();
        }


        private void SelectAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCB.Checked)
                Globals.Clean_SelectCbList(dataGridView, true);
            else
                Globals.Clean_SelectCbList(dataGridView, false);
        }
    }
}
