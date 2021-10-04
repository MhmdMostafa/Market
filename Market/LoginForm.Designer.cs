
namespace Market
{
    partial class LoginForm
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
            this.LoginB = new System.Windows.Forms.Button();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.UserPasswordTB = new System.Windows.Forms.TextBox();
            this.UserNameL = new System.Windows.Forms.Label();
            this.UserPasswordL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.Location = new System.Drawing.Point(109, 114);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(95, 32);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(135, 29);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(151, 26);
            this.UserNameTB.TabIndex = 2;
            // 
            // UserPasswordTB
            // 
            this.UserPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordTB.Location = new System.Drawing.Point(135, 70);
            this.UserPasswordTB.Name = "UserPasswordTB";
            this.UserPasswordTB.Size = new System.Drawing.Size(151, 26);
            this.UserPasswordTB.TabIndex = 3;
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.Location = new System.Drawing.Point(24, 29);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(105, 24);
            this.UserNameL.TabIndex = 4;
            this.UserNameL.Text = "User Name";
            // 
            // UserPasswordL
            // 
            this.UserPasswordL.AutoSize = true;
            this.UserPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordL.Location = new System.Drawing.Point(24, 70);
            this.UserPasswordL.Name = "UserPasswordL";
            this.UserPasswordL.Size = new System.Drawing.Size(92, 24);
            this.UserPasswordL.TabIndex = 5;
            this.UserPasswordL.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 158);
            this.Controls.Add(this.UserPasswordL);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.UserPasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.LoginB);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox UserPasswordTB;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label UserPasswordL;
    }
}