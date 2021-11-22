
namespace Market
{
    partial class CityDGV
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
            this.SelectAllCB = new System.Windows.Forms.CheckBox();
            this.DeleteBT = new MaterialSkin.Controls.MaterialButton();
            this.EditBT = new MaterialSkin.Controls.MaterialButton();
            this.AddBT = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.C0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAllCB
            // 
            this.SelectAllCB.AutoSize = true;
            this.SelectAllCB.Location = new System.Drawing.Point(58, 71);
            this.SelectAllCB.Name = "SelectAllCB";
            this.SelectAllCB.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCB.TabIndex = 9;
            this.SelectAllCB.UseVisualStyleBackColor = true;
            this.SelectAllCB.CheckedChanged += new System.EventHandler(this.SelectAllCB_CheckedChanged);
            // 
            // DeleteBT
            // 
            this.DeleteBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteBT.Depth = 0;
            this.DeleteBT.HighEmphasis = true;
            this.DeleteBT.Icon = null;
            this.DeleteBT.Location = new System.Drawing.Point(291, 249);
            this.DeleteBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBT.Size = new System.Drawing.Size(73, 36);
            this.DeleteBT.TabIndex = 8;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteBT.UseAccentColor = false;
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditBT.Depth = 0;
            this.EditBT.HighEmphasis = true;
            this.EditBT.Icon = null;
            this.EditBT.Location = new System.Drawing.Point(372, 249);
            this.EditBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditBT.Name = "EditBT";
            this.EditBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditBT.Size = new System.Drawing.Size(64, 36);
            this.EditBT.TabIndex = 7;
            this.EditBT.Text = "EDIT";
            this.EditBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditBT.UseAccentColor = false;
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddBT.Depth = 0;
            this.AddBT.HighEmphasis = true;
            this.AddBT.Icon = null;
            this.AddBT.Location = new System.Drawing.Point(444, 249);
            this.AddBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBT.Name = "AddBT";
            this.AddBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddBT.Size = new System.Drawing.Size(64, 36);
            this.AddBT.TabIndex = 6;
            this.AddBT.Text = "ADD";
            this.AddBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddBT.UseAccentColor = false;
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C0,
            this.C1,
            this.C2,
            this.C3,
            this.C4});
            this.dataGridView.Location = new System.Drawing.Point(6, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(504, 173);
            this.dataGridView.TabIndex = 5;
            // 
            // C0
            // 
            this.C0.HeaderText = "";
            this.C0.Name = "C0";
            this.C0.Width = 40;
            // 
            // C1
            // 
            this.C1.DataPropertyName = "ID";
            this.C1.HeaderText = "ID";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 50;
            // 
            // C2
            // 
            this.C2.DataPropertyName = "NameEn";
            this.C2.HeaderText = "English";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C2.Width = 120;
            // 
            // C3
            // 
            this.C3.DataPropertyName = "NameAr";
            this.C3.HeaderText = "Arabic";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C3.Width = 120;
            // 
            // C4
            // 
            this.C4.DataPropertyName = "Country";
            this.C4.HeaderText = "Country";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 135;
            // 
            // CityDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 299);
            this.Controls.Add(this.SelectAllCB);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.dataGridView);
            this.Name = "CityDGV";
            this.Text = "ForTbAndCB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SelectAllCB;
        private MaterialSkin.Controls.MaterialButton DeleteBT;
        private MaterialSkin.Controls.MaterialButton EditBT;
        private MaterialSkin.Controls.MaterialButton AddBT;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C0;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
    }
}