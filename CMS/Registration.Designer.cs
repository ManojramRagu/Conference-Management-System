namespace CMS
{
    partial class Registration
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(322, 176);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(245, 180);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(311, 263);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Create Account";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(246, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(322, 213);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordBox.TabIndex = 4;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.usernameBox);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}

