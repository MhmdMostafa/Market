
namespace Market
{
    partial class OnlyNames
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
            this.NameArTB = new System.Windows.Forms.TextBox();
            this.NameEnTB = new System.Windows.Forms.TextBox();
            this.AddEditBT = new MaterialSkin.Controls.MaterialButton();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameArTB
            // 
            this.NameArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameArTB.Location = new System.Drawing.Point(121, 118);
            this.NameArTB.Name = "NameArTB";
            this.NameArTB.Size = new System.Drawing.Size(280, 32);
            this.NameArTB.TabIndex = 36;
            // 
            // NameEnTB
            // 
            this.NameEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameEnTB.Location = new System.Drawing.Point(121, 80);
            this.NameEnTB.Name = "NameEnTB";
            this.NameEnTB.Size = new System.Drawing.Size(280, 32);
            this.NameEnTB.TabIndex = 35;
            // 
            // AddEditBT
            // 
            this.AddEditBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEditBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddEditBT.Depth = 0;
            this.AddEditBT.HighEmphasis = true;
            this.AddEditBT.Icon = null;
            this.AddEditBT.Location = new System.Drawing.Point(336, 158);
            this.AddEditBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddEditBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEditBT.Name = "AddEditBT";
            this.AddEditBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddEditBT.Size = new System.Drawing.Size(65, 36);
            this.AddEditBT.TabIndex = 33;
            this.AddEditBT.Text = "lable";
            this.AddEditBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddEditBT.UseAccentColor = false;
            this.AddEditBT.UseVisualStyleBackColor = true;
            this.AddEditBT.Click += new System.EventHandler(this.AddEditBT_Click);
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(9, 121);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(106, 24);
            this.label_3.TabIndex = 32;
            this.label_3.Text = "Name Ar:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(9, 83);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(106, 24);
            this.label_2.TabIndex = 31;
            this.label_2.Text = "Name En:";
            // 
            // OnlyNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 203);
            this.Controls.Add(this.NameArTB);
            this.Controls.Add(this.NameEnTB);
            this.Controls.Add(this.AddEditBT);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Name = "OnlyNames";
            this.Text = "OnlyNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameArTB;
        private System.Windows.Forms.TextBox NameEnTB;
        private MaterialSkin.Controls.MaterialButton AddEditBT;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
    }
}
