﻿
namespace Market
{
    partial class AddContact
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
            this.applyB = new MaterialSkin.Controls.MaterialButton();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.CountryCB = new System.Windows.Forms.ComboBox();
            this.AddTypeB = new System.Windows.Forms.Button();
            this.AddContryb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applyB
            // 
            this.applyB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyB.Depth = 0;
            this.applyB.HighEmphasis = true;
            this.applyB.Icon = null;
            this.applyB.Location = new System.Drawing.Point(315, 174);
            this.applyB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyB.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyB.Name = "applyB";
            this.applyB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyB.Size = new System.Drawing.Size(65, 36);
            this.applyB.TabIndex = 0;
            this.applyB.Text = "apply";
            this.applyB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyB.UseAccentColor = false;
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.PhoneTB.Location = new System.Drawing.Point(192, 133);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(190, 32);
            this.PhoneTB.TabIndex = 26;
            this.PhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB_KeyPress);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(6, 136);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(58, 24);
            this.label_1.TabIndex = 25;
            this.label_1.Text = "No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Contact Type:";
            // 
            // typeCB
            // 
            this.typeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(178, 83);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(159, 32);
            this.typeCB.TabIndex = 28;
            // 
            // CountryCB
            // 
            this.CountryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CountryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CountryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.CountryCB.FormattingEnabled = true;
            this.CountryCB.Location = new System.Drawing.Point(70, 133);
            this.CountryCB.Name = "CountryCB";
            this.CountryCB.Size = new System.Drawing.Size(80, 32);
            this.CountryCB.TabIndex = 29;
            // 
            // AddTypeB
            // 
            this.AddTypeB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddTypeB.Location = new System.Drawing.Point(343, 83);
            this.AddTypeB.Name = "AddTypeB";
            this.AddTypeB.Size = new System.Drawing.Size(39, 32);
            this.AddTypeB.TabIndex = 30;
            this.AddTypeB.Text = "+";
            this.AddTypeB.UseVisualStyleBackColor = true;
            this.AddTypeB.Click += new System.EventHandler(this.AddTypeB_Click);
            // 
            // AddContryb
            // 
            this.AddContryb.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddContryb.Location = new System.Drawing.Point(156, 133);
            this.AddContryb.Name = "AddContryb";
            this.AddContryb.Size = new System.Drawing.Size(30, 32);
            this.AddContryb.TabIndex = 31;
            this.AddContryb.Text = "+";
            this.AddContryb.UseVisualStyleBackColor = true;
            this.AddContryb.Click += new System.EventHandler(this.AddContryb_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 220);
            this.Controls.Add(this.AddContryb);
            this.Controls.Add(this.AddTypeB);
            this.Controls.Add(this.CountryCB);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.applyB);
            this.Name = "AddContact";
            this.Text = "AddContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton applyB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.ComboBox CountryCB;
        private System.Windows.Forms.Button AddTypeB;
        private System.Windows.Forms.Button AddContryb;
    }
}
