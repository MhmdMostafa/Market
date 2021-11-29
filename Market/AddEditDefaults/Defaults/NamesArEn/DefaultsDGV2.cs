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
    //this form is used to (add, edit, Delete) tables value that have only 2 feilds (NameEn, NameAr) using other form called only names
    public partial class DefaultsDGV2 : MaterialSkin.Controls.MaterialForm
    {
        string SQLtable;
        public DefaultsDGV2()
        {
            InitializeComponent();
        }

        public DefaultsDGV2(string table)
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

        private void AddB_Click(object sender, EventArgs e)
        {
            OnlyNames window = new OnlyNames("add", SQLtable);
            window.ShowDialog();
            refreshTap();

        }

        private void EditB_Click(object sender, EventArgs e)
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

            OnlyNames window = new OnlyNames("edit", SQLtable, selectedValues[0]);
            window.ShowDialog();
            refreshTap();

        }

        private void DeleteB_Click(object sender, EventArgs e)
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
