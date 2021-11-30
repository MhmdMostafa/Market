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
    public partial class EmpsDGV : MaterialSkin.Controls.MaterialForm
    {
        public EmpsDGV()
        {
            InitializeComponent();
            Text = "Emplyees";
            refresh();

        }

        private void AddB_Click(object sender, EventArgs e)
        {
            MainEmp window = new MainEmp("add");
            window.ShowDialog();
            refresh();
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(EMBDGV);
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
            refresh();
        }

        private void SelectAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCb.Checked)
                Globals.Clean_SelectCbList(EMBDGV, true);
            else
                Globals.Clean_SelectCbList(EMBDGV, false);
        }

        public void refresh()
        {
            string SQL = $"SELECT employees.ID, UserName, employees.NameEn, employees.NameAr, BirthDate, NationalNumber, emp_group.NameEn as GroupID, gender.NameEn as Gender FROM employees INNER JOIN gender ON employees.GenderID=gender.ID INNER JOIN emp_group ON employees.EmpGroupID=emp_group.ID;";
            EMBDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }
    }
}
