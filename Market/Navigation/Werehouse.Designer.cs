
namespace Market
{
    partial class Werehouse
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
            this.components = new System.ComponentModel.Container();
            this.Taps = new System.Windows.Forms.TabControl();
            this.WerehouseTap = new System.Windows.Forms.TabPage();
            this.NameArTB = new System.Windows.Forms.TextBox();
            this.NameEnTB = new System.Windows.Forms.TextBox();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.NavigationTap = new System.Windows.Forms.TabPage();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneBT = new MaterialSkin.Controls.MaterialButton();
            this.AddDeleteSectionStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddSectionB = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSectionB = new System.Windows.Forms.ToolStripMenuItem();
            this.Taps.SuspendLayout();
            this.WerehouseTap.SuspendLayout();
            this.NavigationTap.SuspendLayout();
            this.AddDeleteSectionStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Taps
            // 
            this.Taps.Controls.Add(this.WerehouseTap);
            this.Taps.Controls.Add(this.NavigationTap);
            this.Taps.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.Taps.Location = new System.Drawing.Point(6, 67);
            this.Taps.Name = "Taps";
            this.Taps.SelectedIndex = 0;
            this.Taps.Size = new System.Drawing.Size(497, 493);
            this.Taps.TabIndex = 0;
            // 
            // WerehouseTap
            // 
            this.WerehouseTap.Controls.Add(this.NameArTB);
            this.WerehouseTap.Controls.Add(this.NameEnTB);
            this.WerehouseTap.Controls.Add(this.label_3);
            this.WerehouseTap.Controls.Add(this.label_2);
            this.WerehouseTap.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.WerehouseTap.Location = new System.Drawing.Point(4, 33);
            this.WerehouseTap.Name = "WerehouseTap";
            this.WerehouseTap.Padding = new System.Windows.Forms.Padding(3);
            this.WerehouseTap.Size = new System.Drawing.Size(489, 456);
            this.WerehouseTap.TabIndex = 0;
            this.WerehouseTap.Text = "Werehouse";
            this.WerehouseTap.UseVisualStyleBackColor = true;
            // 
            // NameArTB
            // 
            this.NameArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameArTB.Location = new System.Drawing.Point(118, 80);
            this.NameArTB.Name = "NameArTB";
            this.NameArTB.Size = new System.Drawing.Size(280, 32);
            this.NameArTB.TabIndex = 40;
            // 
            // NameEnTB
            // 
            this.NameEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameEnTB.Location = new System.Drawing.Point(118, 42);
            this.NameEnTB.Name = "NameEnTB";
            this.NameEnTB.Size = new System.Drawing.Size(280, 32);
            this.NameEnTB.TabIndex = 39;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(6, 83);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(106, 24);
            this.label_3.TabIndex = 38;
            this.label_3.Text = "Name Ar:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(6, 45);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(106, 24);
            this.label_2.TabIndex = 37;
            this.label_2.Text = "Name En:";
            // 
            // NavigationTap
            // 
            this.NavigationTap.Controls.Add(this.treeView);
            this.NavigationTap.Controls.Add(this.label1);
            this.NavigationTap.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NavigationTap.Location = new System.Drawing.Point(4, 33);
            this.NavigationTap.Name = "NavigationTap";
            this.NavigationTap.Padding = new System.Windows.Forms.Padding(3);
            this.NavigationTap.Size = new System.Drawing.Size(489, 456);
            this.NavigationTap.TabIndex = 1;
            this.NavigationTap.Text = "Navigation";
            this.NavigationTap.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(10, 30);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(473, 381);
            this.treeView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sections";
            // 
            // DoneBT
            // 
            this.DoneBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoneBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DoneBT.Depth = 0;
            this.DoneBT.HighEmphasis = true;
            this.DoneBT.Icon = null;
            this.DoneBT.Location = new System.Drawing.Point(435, 569);
            this.DoneBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DoneBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneBT.Name = "DoneBT";
            this.DoneBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DoneBT.Size = new System.Drawing.Size(64, 36);
            this.DoneBT.TabIndex = 41;
            this.DoneBT.Text = "Done";
            this.DoneBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DoneBT.UseAccentColor = false;
            this.DoneBT.UseVisualStyleBackColor = true;
            this.DoneBT.Click += new System.EventHandler(this.DoneBT_Click);
            // 
            // AddDeleteSectionStrip
            // 
            this.AddDeleteSectionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSectionB,
            this.DeleteSectionB});
            this.AddDeleteSectionStrip.Name = "contextMenuStrip1";
            this.AddDeleteSectionStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // AddSectionB
            // 
            this.AddSectionB.Name = "AddSectionB";
            this.AddSectionB.Size = new System.Drawing.Size(149, 22);
            this.AddSectionB.Text = "Add Section";
            this.AddSectionB.Click += new System.EventHandler(this.AddSectionB_Click);
            // 
            // DeleteSectionB
            // 
            this.DeleteSectionB.Name = "DeleteSectionB";
            this.DeleteSectionB.Size = new System.Drawing.Size(149, 22);
            this.DeleteSectionB.Text = "Delete Section";
            // 
            // Werehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 614);
            this.Controls.Add(this.DoneBT);
            this.Controls.Add(this.Taps);
            this.Name = "Werehouse";
            this.Text = "NavigationControl";
            this.Taps.ResumeLayout(false);
            this.WerehouseTap.ResumeLayout(false);
            this.WerehouseTap.PerformLayout();
            this.NavigationTap.ResumeLayout(false);
            this.NavigationTap.PerformLayout();
            this.AddDeleteSectionStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Taps;
        private System.Windows.Forms.TabPage WerehouseTap;
        private System.Windows.Forms.TabPage NavigationTap;
        private System.Windows.Forms.TextBox NameArTB;
        private System.Windows.Forms.TextBox NameEnTB;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private MaterialSkin.Controls.MaterialButton DoneBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip AddDeleteSectionStrip;
        private System.Windows.Forms.ToolStripMenuItem AddSectionB;
        private System.Windows.Forms.ToolStripMenuItem DeleteSectionB;
        private System.Windows.Forms.TreeView treeView;
    }
}