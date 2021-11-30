
namespace Market
{
    partial class AddEditBank
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
            this.BankArTB = new System.Windows.Forms.TextBox();
            this.NameAr = new System.Windows.Forms.Label();
            this.BankEnTB = new System.Windows.Forms.TextBox();
            this.NameEn = new System.Windows.Forms.Label();
            this.IbanTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyB = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BankArTB
            // 
            this.BankArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.BankArTB.Location = new System.Drawing.Point(178, 165);
            this.BankArTB.Name = "BankArTB";
            this.BankArTB.Size = new System.Drawing.Size(204, 32);
            this.BankArTB.TabIndex = 28;
            // 
            // NameAr
            // 
            this.NameAr.AutoSize = true;
            this.NameAr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAr.Location = new System.Drawing.Point(6, 168);
            this.NameAr.Name = "NameAr";
            this.NameAr.Size = new System.Drawing.Size(166, 24);
            this.NameAr.TabIndex = 27;
            this.NameAr.Text = "Bank Name Ar:";
            // 
            // BankEnTB
            // 
            this.BankEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.BankEnTB.Location = new System.Drawing.Point(178, 127);
            this.BankEnTB.Name = "BankEnTB";
            this.BankEnTB.Size = new System.Drawing.Size(204, 32);
            this.BankEnTB.TabIndex = 30;
            // 
            // NameEn
            // 
            this.NameEn.AllowDrop = true;
            this.NameEn.AutoSize = true;
            this.NameEn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEn.Location = new System.Drawing.Point(6, 130);
            this.NameEn.Name = "NameEn";
            this.NameEn.Size = new System.Drawing.Size(166, 24);
            this.NameEn.TabIndex = 29;
            this.NameEn.Text = "Bank Name En:";
            // 
            // IbanTB
            // 
            this.IbanTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.IbanTB.Location = new System.Drawing.Point(82, 203);
            this.IbanTB.Name = "IbanTB";
            this.IbanTB.Size = new System.Drawing.Size(300, 32);
            this.IbanTB.TabIndex = 32;
            this.IbanTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IbanTB_keyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Iban:";
            // 
            // FullNameTB
            // 
            this.FullNameTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.FullNameTB.Location = new System.Drawing.Point(142, 89);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(240, 32);
            this.FullNameTB.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Full Name:";
            // 
            // applyB
            // 
            this.applyB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyB.Depth = 0;
            this.applyB.HighEmphasis = true;
            this.applyB.Icon = null;
            this.applyB.Location = new System.Drawing.Point(315, 244);
            this.applyB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyB.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyB.Name = "applyB";
            this.applyB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyB.Size = new System.Drawing.Size(67, 36);
            this.applyB.TabIndex = 35;
            this.applyB.Text = "apply";
            this.applyB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyB.UseAccentColor = false;
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(82, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 32);
            this.comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69"});
            this.comboBox2.Location = new System.Drawing.Point(178, 241);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(81, 32);
            this.comboBox2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "/";
            // 
            // AddEditBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyB);
            this.Controls.Add(this.FullNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IbanTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankEnTB);
            this.Controls.Add(this.NameEn);
            this.Controls.Add(this.BankArTB);
            this.Controls.Add(this.NameAr);
            this.Name = "AddEditBank";
            this.Text = "AddEditBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BankArTB;
        private System.Windows.Forms.Label NameAr;
        private System.Windows.Forms.TextBox BankEnTB;
        private System.Windows.Forms.Label NameEn;
        private System.Windows.Forms.TextBox IbanTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton applyB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}
