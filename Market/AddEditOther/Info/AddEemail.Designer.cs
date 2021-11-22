
namespace Market
{
    partial class AddEemail
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
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.applyB = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EmailTB.Location = new System.Drawing.Point(49, 110);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(285, 32);
            this.EmailTB.TabIndex = 24;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(6, 83);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(82, 24);
            this.label_1.TabIndex = 23;
            this.label_1.Text = "Email:";
            // 
            // applyB
            // 
            this.applyB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyB.Depth = 0;
            this.applyB.HighEmphasis = true;
            this.applyB.Icon = null;
            this.applyB.Location = new System.Drawing.Point(318, 154);
            this.applyB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyB.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyB.Name = "applyB";
            this.applyB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyB.Size = new System.Drawing.Size(67, 36);
            this.applyB.TabIndex = 25;
            this.applyB.Text = "Apply";
            this.applyB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyB.UseAccentColor = false;
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // AEemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.applyB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.label_1);
            this.Name = "AEemail";
            this.Text = "AddAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label_1;
        private MaterialSkin.Controls.MaterialButton applyB;
    }
}