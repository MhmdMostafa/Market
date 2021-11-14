
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
            this.DeleteUserB = new System.Windows.Forms.Button();
            this.AddUserB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.MySQLTap.SuspendLayout();
            this.AdminTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MySQLTap);
            this.TabControl.Controls.Add(this.AdminTap);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(352, 413);
            this.TabControl.TabIndex = 0;
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
            this.AdminTap.Controls.Add(this.DeleteUserB);
            this.AdminTap.Controls.Add(this.AddUserB);
            this.AdminTap.Controls.Add(this.dataGridView1);
            this.AdminTap.Controls.Add(this.button3);
            this.AdminTap.Location = new System.Drawing.Point(4, 27);
            this.AdminTap.Name = "AdminTap";
            this.AdminTap.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTap.Size = new System.Drawing.Size(344, 382);
            this.AdminTap.TabIndex = 1;
            this.AdminTap.Text = "Administration";
            this.AdminTap.UseVisualStyleBackColor = true;
            // 
            // DeleteUserB
            // 
            this.DeleteUserB.Location = new System.Drawing.Point(57, 304);
            this.DeleteUserB.Name = "DeleteUserB";
            this.DeleteUserB.Size = new System.Drawing.Size(234, 33);
            this.DeleteUserB.TabIndex = 4;
            this.DeleteUserB.Text = "Delete User";
            this.DeleteUserB.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 243);
            this.dataGridView1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button DeleteUserB;
        private System.Windows.Forms.Button AddUserB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}