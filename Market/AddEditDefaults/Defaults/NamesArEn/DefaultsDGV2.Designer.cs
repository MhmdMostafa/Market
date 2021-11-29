
namespace Market
{
    partial class DefaultsDGV2
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
            this.DeleteB = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CBGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditB = new MaterialSkin.Controls.MaterialButton();
            this.AddB = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAllCB
            // 
            this.SelectAllCB.AutoSize = true;
            this.SelectAllCB.Location = new System.Drawing.Point(66, 71);
            this.SelectAllCB.Name = "SelectAllCB";
            this.SelectAllCB.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCB.TabIndex = 10;
            this.SelectAllCB.UseVisualStyleBackColor = true;
            this.SelectAllCB.CheckedChanged += new System.EventHandler(this.SelectAllCB_CheckedChanged);
            // 
            // DeleteB
            // 
            this.DeleteB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteB.Depth = 0;
            this.DeleteB.HighEmphasis = true;
            this.DeleteB.Icon = null;
            this.DeleteB.Location = new System.Drawing.Point(332, 279);
            this.DeleteB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteB.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteB.Size = new System.Drawing.Size(73, 36);
            this.DeleteB.TabIndex = 9;
            this.DeleteB.Text = "Delete";
            this.DeleteB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteB.UseAccentColor = false;
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBGV,
            this.ID,
            this.NameEn,
            this.NameAr});
            this.dataGridView.Location = new System.Drawing.Point(11, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(543, 203);
            this.dataGridView.TabIndex = 6;
            // 
            // CBGV
            // 
            this.CBGV.HeaderText = "";
            this.CBGV.Name = "CBGV";
            this.CBGV.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // NameEn
            // 
            this.NameEn.DataPropertyName = "NameEn";
            this.NameEn.HeaderText = "English";
            this.NameEn.Name = "NameEn";
            this.NameEn.ReadOnly = true;
            this.NameEn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameEn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameEn.Width = 200;
            // 
            // NameAr
            // 
            this.NameAr.DataPropertyName = "NameAr";
            this.NameAr.HeaderText = "Arabic";
            this.NameAr.Name = "NameAr";
            this.NameAr.ReadOnly = true;
            this.NameAr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameAr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameAr.Width = 200;
            // 
            // EditB
            // 
            this.EditB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditB.Depth = 0;
            this.EditB.HighEmphasis = true;
            this.EditB.Icon = null;
            this.EditB.Location = new System.Drawing.Point(413, 279);
            this.EditB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditB.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditB.Name = "EditB";
            this.EditB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditB.Size = new System.Drawing.Size(64, 36);
            this.EditB.TabIndex = 8;
            this.EditB.Text = "EDIT";
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
            this.AddB.Location = new System.Drawing.Point(485, 279);
            this.AddB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddB.Name = "AddB";
            this.AddB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddB.Size = new System.Drawing.Size(64, 36);
            this.AddB.TabIndex = 7;
            this.AddB.Text = "ADD";
            this.AddB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddB.UseAccentColor = false;
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // For2TB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 328);
            this.Controls.Add(this.SelectAllCB);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Name = "For2TB";
            this.Text = "For2TB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SelectAllCB;
        private MaterialSkin.Controls.MaterialButton DeleteB;
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialButton EditB;
        private MaterialSkin.Controls.MaterialButton AddB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAr;
    }
}
