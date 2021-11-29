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
    public partial class DefaultsDGV1 : MaterialSkin.Controls.MaterialForm
    {
        string SQLtable;
        public DefaultsDGV1()
        {
            InitializeComponent();
        }

        public DefaultsDGV1(string table)
        {
            InitializeComponent();
            SQLtable = table;
            refreshTap();
            Text = table.ToUpper();
        }

        private void refreshTap()
        {
            string SQL;
            SQL = $@"SELECT * FROM {SQLtable};";
            dataGridView.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }


        private void AddBT_Click(object sender, EventArgs e)
        {

            NamesWithShortcut window = new NamesWithShortcut("add", SQLtable);
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

            NamesWithShortcut window = new NamesWithShortcut("edit", SQLtable, selectedValues[0]);
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
