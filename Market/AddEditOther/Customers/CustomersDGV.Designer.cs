
namespace Market
{
    partial class CustomersDGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CUDGV = new System.Windows.Forms.DataGridView();
            this.EditB = new MaterialSkin.Controls.MaterialButton();
            this.AddB = new MaterialSkin.Controls.MaterialButton();
            this.SelectAllCb = new System.Windows.Forms.CheckBox();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CUDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CUDGV
            // 
            this.CUDGV.AllowUserToAddRows = false;
            this.CUDGV.AllowUserToDeleteRows = false;
            this.CUDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CUDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.CustomerGroup});
            this.CUDGV.Location = new System.Drawing.Point(6, 67);
            this.CUDGV.Name = "CUDGV";
            this.CUDGV.Size = new System.Drawing.Size(729, 314);
            this.CUDGV.TabIndex = 20;
            // 
            // EditB
            // 
            this.EditB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditB.Depth = 0;
            this.EditB.HighEmphasis = true;
            this.EditB.Icon = null;
            this.EditB.Location = new System.Drawing.Point(598, 390);
            this.EditB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditB.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditB.Name = "EditB";
            this.EditB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditB.Size = new System.Drawing.Size(64, 36);
            this.EditB.TabIndex = 22;
            this.EditB.Text = "Edit";
            this.EditB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditB.UseAccentColor = false;
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // AddB
            // 
            this.AddB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddB.Depth = 0;
            this.AddB.HighEmphasis = true;
            this.AddB.Icon = null;
            this.AddB.Location = new System.Drawing.Point(670, 390);
            this.AddB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddB.Name = "AddB";
            this.AddB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddB.Size = new System.Drawing.Size(64, 36);
            this.AddB.TabIndex = 21;
            this.AddB.Text = "Add";
            this.AddB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddB.UseAccentColor = false;
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SelectAllCb
            // 
            this.SelectAllCb.AutoSize = true;
            this.SelectAllCb.Location = new System.Drawing.Point(49, 82);
            this.SelectAllCb.Name = "SelectAllCb";
            this.SelectAllCb.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCb.TabIndex = 24;
            this.SelectAllCb.UseVisualStyleBackColor = true;
            this.SelectAllCb.CheckedChanged += new System.EventHandler(this.SelectAllCb_CheckedChanged);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameEn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name En";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameAr";
            this.dataGridViewTextBoxColumn3.HeaderText = "NameAr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn4.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Birth Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NationalNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "National No.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Gender";
            this.Column1.HeaderText = "Gender";
            this.Column1.Name = "Column1";
            // 
            // CustomerGroup
            // 
            this.CustomerGroup.DataPropertyName = "GroupID";
            this.CustomerGroup.HeaderText = "Group";
            this.CustomerGroup.Name = "CustomerGroup";
            // 
            // CustomersDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 435);
            this.Controls.Add(this.SelectAllCb);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.CUDGV);
            this.Name = "CustomersDGV";
            this.Text = "CustomersDGV";
            ((System.ComponentModel.ISupportInitialize)(this.CUDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CUDGV;
        private MaterialSkin.Controls.MaterialButton EditB;
        private MaterialSkin.Controls.MaterialButton AddB;
        private System.Windows.Forms.CheckBox SelectAllCb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGroup;
    }
}