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
    public partial class CityDGV : MaterialSkin.Controls.MaterialForm
    {
        string SQLtable;
        public CityDGV()
        {
            InitializeComponent();
        }

        public CityDGV(string table)
        {
            InitializeComponent();
            SQLtable = table;
            refreshTap();
            Text = table.ToUpper();
        }

        private void refreshTap()
        {
            string SQL;
            SQL = $@"SELECT cities.ID, countries.NameEn as Country, cities.NameEn, cities.NameAr FROM market.cities INNER JOIN countries ON cities.CountryID=countries.ID;";
            dataGridView.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            TwoTbWithCb window = new TwoTbWithCb("add", SQLtable);
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

            TwoTbWithCb window = new TwoTbWithCb("edit", SQLtable, selectedValues[0]);
            window.ShowDialog();
            refreshTap();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(dataGridView);
            if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to Delete");
                return;
            }

            foreach (int value in selectedValues)
            {
                Globals.DeleteValue(SQLtable, "ID", value);
            }

            MessageBox.Show("Done!!");
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
