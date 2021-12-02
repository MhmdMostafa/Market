
namespace Market
{
    partial class OptionsForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MySQLTap = new System.Windows.Forms.TabPage();
            this.DatabasecfgTB = new System.Windows.Forms.TextBox();
            this.PasswordcfgTB = new System.Windows.Forms.TextBox();
            this.UsercfgTB = new System.Windows.Forms.TextBox();
            this.HostcfgTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminTap = new System.Windows.Forms.TabPage();
            this.EditUserB = new System.Windows.Forms.Button();
            this.AddUserB = new System.Windows.Forms.Button();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NameEnTb = new System.Windows.Forms.TextBox();
            this.ContactNumberTb = new System.Windows.Forms.TextBox();
            this.TaxNumberTb = new System.Windows.Forms.TextBox();
            this.CommercialRegisterTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameArTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VATTb = new System.Windows.Forms.NumericUpDown();
            this.SelectAllUsersCB = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabControl.SuspendLayout();
            this.MySQLTap.SuspendLayout();
            this.AdminTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VATTb)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MySQLTap);
            this.TabControl.Controls.Add(this.AdminTap);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(352, 413);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // MySQLTap
            // 
            this.MySQLTap.Controls.Add(this.DatabasecfgTB);
            this.MySQLTap.Controls.Add(this.PasswordcfgTB);
            this.MySQLTap.Controls.Add(this.UsercfgTB);
            this.MySQLTap.Controls.Add(this.HostcfgTB);
            this.MySQLTap.Controls.Add(this.label4);
            this.MySQLTap.Controls.Add(this.label3);
            this.MySQLTap.Controls.Add(this.label2);
            this.MySQLTap.Controls.Add(this.label1);
            this.MySQLTap.Location = new System.Drawing.Point(4, 27);
            this.MySQLTap.Name = "MySQLTap";
            this.MySQLTap.Padding = new System.Windows.Forms.Padding(3);
            this.MySQLTap.Size = new System.Drawing.Size(344, 382);
            this.MySQLTap.TabIndex = 0;
            this.MySQLTap.Text = "MySQL";
            this.MySQLTap.UseVisualStyleBackColor = true;
            // 
            // DatabasecfgTB
            // 
            this.DatabasecfgTB.Location = new System.Drawing.Point(128, 134);
            this.DatabasecfgTB.Name = "DatabasecfgTB";
            this.DatabasecfgTB.Size = new System.Drawing.Size(196, 24);
            this.DatabasecfgTB.TabIndex = 7;
            // 
            // PasswordcfgTB
            // 
            this.PasswordcfgTB.Location = new System.Drawing.Point(128, 95);
            this.PasswordcfgTB.Name = "PasswordcfgTB";
            this.PasswordcfgTB.PasswordChar = '*';
            this.PasswordcfgTB.Size = new System.Drawing.Size(196, 24);
            this.PasswordcfgTB.TabIndex = 6;
            // 
            // UsercfgTB
            // 
            this.UsercfgTB.Location = new System.Drawing.Point(128, 53);
            this.UsercfgTB.Name = "UsercfgTB";
            this.UsercfgTB.Size = new System.Drawing.Size(196, 24);
            this.UsercfgTB.TabIndex = 5;
            // 
            // HostcfgTB
            // 
            this.HostcfgTB.Location = new System.Drawing.Point(128, 16);
            this.HostcfgTB.Name = "HostcfgTB";
            this.HostcfgTB.Size = new System.Drawing.Size(196, 24);
            this.HostcfgTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // AdminTap
            // 
            this.AdminTap.Controls.Add(this.SelectAllUsersCB);
            this.AdminTap.Controls.Add(this.EditUserB);
            this.AdminTap.Controls.Add(this.AddUserB);
            this.AdminTap.Controls.Add(this.UsersDGV);
            this.AdminTap.Controls.Add(this.button3);
            this.AdminTap.Location = new System.Drawing.Point(4, 27);
            this.AdminTap.Name = "AdminTap";
            this.AdminTap.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTap.Size = new System.Drawing.Size(344, 382);
            this.AdminTap.TabIndex = 1;
            this.AdminTap.Text = "Administration";
            this.AdminTap.UseVisualStyleBackColor = true;
            // 
            // EditUserB
            // 
            this.EditUserB.Location = new System.Drawing.Point(57, 304);
            this.EditUserB.Name = "EditUserB";
            this.EditUserB.Size = new System.Drawing.Size(234, 33);
            this.EditUserB.TabIndex = 4;
            this.EditUserB.Text = "Edit User";
            this.EditUserB.UseVisualStyleBackColor = true;
            this.EditUserB.Click += new System.EventHandler(this.EditUserB_Click);
            // 
            // AddUserB
            // 
            this.AddUserB.Location = new System.Drawing.Point(57, 265);
            this.AddUserB.Name = "AddUserB";
            this.AddUserB.Size = new System.Drawing.Size(234, 33);
            this.AddUserB.TabIndex = 3;
            this.AddUserB.Text = "Add User";
            this.AddUserB.UseVisualStyleBackColor = true;
            this.AddUserB.Click += new System.EventHandler(this.AddUserB_Click);
            // 
            // UsersDGV
            // 
            this.UsersDGV.AllowUserToAddRows = false;
            this.UsersDGV.AllowUserToDeleteRows = false;
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1});
            this.UsersDGV.Location = new System.Drawing.Point(15, 16);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.Size = new System.Drawing.Size(313, 243);
            this.UsersDGV.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Permissions";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(313, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(237, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VATTb);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.NameArTb);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.NameEnTb);
            this.tabPage1.Controls.Add(this.ContactNumberTb);
            this.tabPage1.Controls.Add(this.TaxNumberTb);
            this.tabPage1.Controls.Add(this.CommercialRegisterTb);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 382);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Main Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NameEnTb
            // 
            this.NameEnTb.Location = new System.Drawing.Point(10, 199);
            this.NameEnTb.Name = "NameEnTb";
            this.NameEnTb.Size = new System.Drawing.Size(328, 24);
            this.NameEnTb.TabIndex = 15;
            // 
            // ContactNumberTb
            // 
            this.ContactNumberTb.Location = new System.Drawing.Point(10, 146);
            this.ContactNumberTb.Name = "ContactNumberTb";
            this.ContactNumberTb.Size = new System.Drawing.Size(328, 24);
            this.ContactNumberTb.TabIndex = 14;
            // 
            // TaxNumberTb
            // 
            this.TaxNumberTb.Location = new System.Drawing.Point(10, 93);
            this.TaxNumberTb.Name = "TaxNumberTb";
            this.TaxNumberTb.Size = new System.Drawing.Size(328, 24);
            this.TaxNumberTb.TabIndex = 13;
            // 
            // CommercialRegisterTb
            // 
            this.CommercialRegisterTb.Location = new System.Drawing.Point(10, 40);
            this.CommercialRegisterTb.Name = "CommercialRegisterTb";
            this.CommercialRegisterTb.Size = new System.Drawing.Size(328, 24);
            this.CommercialRegisterTb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name En:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tax Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Commercial Register:";
            // 
            // NameArTb
            // 
            this.NameArTb.Location = new System.Drawing.Point(10, 252);
            this.NameArTb.Name = "NameArTb";
            this.NameArTb.Size = new System.Drawing.Size(328, 24);
            this.NameArTb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name Ar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "VAT %:";
            // 
            // VATTb
            // 
            this.VATTb.DecimalPlaces = 2;
            this.VATTb.Location = new System.Drawing.Point(10, 305);
            this.VATTb.Name = "VATTb";
            this.VATTb.Size = new System.Drawing.Size(120, 24);
            this.VATTb.TabIndex = 19;
            // 
            // SelectAllUsersCB
            // 
            this.SelectAllUsersCB.AutoSize = true;
            this.SelectAllUsersCB.Location = new System.Drawing.Point(64, 19);
            this.SelectAllUsersCB.Name = "SelectAllUsersCB";
            this.SelectAllUsersCB.Size = new System.Drawing.Size(15, 14);
            this.SelectAllUsersCB.TabIndex = 5;
            this.SelectAllUsersCB.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.HeaderText = "";
            this.c1.Name = "c1";
            this.c1.Width = 30;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabControl);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.TabControl.ResumeLayout(false);
            this.MySQLTap.ResumeLayout(false);
            this.MySQLTap.PerformLayout();
            this.AdminTap.ResumeLayout(false);
            this.AdminTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VATTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MySQLTap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage AdminTap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DatabasecfgTB;
        private System.Windows.Forms.TextBox PasswordcfgTB;
        private System.Windows.Forms.TextBox UsercfgTB;
        private System.Windows.Forms.TextBox HostcfgTB;
        private System.Windows.Forms.Button EditUserB;
        private System.Windows.Forms.Button AddUserB;
        private System.Windows.Forms.DataGridView UsersDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown VATTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NameArTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameEnTb;
        private System.Windows.Forms.TextBox ContactNumberTb;
        private System.Windows.Forms.TextBox TaxNumberTb;
        private System.Windows.Forms.TextBox CommercialRegisterTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox SelectAllUsersCB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c1;
    }
}