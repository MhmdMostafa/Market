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
    public partial class Werehouse : MaterialSkin.Controls.MaterialForm
    {


        public string SQLtable;
        public int SelectedID;
        public string command;
        public List<TreeNode> Sections = new List<TreeNode>();
        public Werehouse()
        {
            InitializeComponent();
        }

        public Werehouse(string conf, string table, int id)
        {
            InitializeComponent();
            SQLtable = table;
            SelectedID = id;
            command = conf;

            TreeNode RowsName = new TreeNode("RowsName");
            TreeNode ColumnName = new TreeNode("ColumnName");
            TreeNode RowsNode = new TreeNode("RowsNode", new TreeNode[] { RowsName });
            TreeNode ColumnNode = new TreeNode("ColumnNode", new TreeNode[] { ColumnName });
            TreeNode SubSubSectionNode = new TreeNode("SubSubSectionNode", new TreeNode[] { RowsNode, ColumnNode });
            TreeNode SubSectionNode = new TreeNode("SubSectionNode", new TreeNode[] { SubSubSectionNode });
            TreeNode SectionNode = new TreeNode("SectionNode", new TreeNode[] { SubSectionNode });

            SectionNode.Name = "SectionNode";
            SectionNode.Text = "SectionNode";
            SubSectionNode.Name = "SubSectionNode";
            SubSectionNode.Text = "SubSectionNode";
            SubSubSectionNode.Name = "SubSubSectionNode";
            SubSubSectionNode.Text = "SubSubSectionNode";
            RowsNode.Name = "RowsNode";
            RowsNode.Text = "RowsNode";
            ColumnNode.Name = "ColumnNode";
            ColumnNode.Text = "ColumnNode";
            RowsName.Name = "RowsName";
            RowsName.Text = "RowsName";
            ColumnName.Name = "ColumnName";
            ColumnName.Text = "ColumnName";

            Sections.Add(SectionNode);

            for (int i = 0; i < 30; i++)
            {
                TreeNode newNode = new TreeNode();
                newNode.Name = $"{i}-Node";
                newNode.Text = $"{i}-Node";
                Sections.Add(newNode);
            }
            refreshTree();
        }

        private void DoneBT_Click(object sender, EventArgs e)
        {

        }

        private void AddSectionB_Click(object sender, EventArgs e)
        {

        }


        public void refreshTree()
        {
            treeView.Nodes.Clear();
            treeView.Nodes.AddRange(Sections.ToArray());
        }
    }
}
