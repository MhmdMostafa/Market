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
    public partial class WarehousesDGV : MaterialSkin.Controls.MaterialForm
    {
        public WarehousesDGV()
        {
            InitializeComponent();
        }

        public WarehousesDGV(string table)
        {
            InitializeComponent();
            refreshTap();
            Text = table.ToUpper();
        }

        private void refreshTap()
        {
            dataGridView.DataSource = Globals.myCrud.getDtPassSql($@"SELECT warehouses_Type.NameEn as Type, NameEn, NameAr FROM warehouses;");
        }


        private void AddBT_Click(object sender, EventArgs e)
        {
            MainWarehouses window = new MainWarehouses("add");
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

            MainWarehouses window = new MainWarehouses("edit", selectedValues[0]);
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
