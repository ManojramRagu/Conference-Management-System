namespace CMS
{
    partial class RegistrationUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterPwdAgain = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(393, 177);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(245, 183);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(52, 201);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(247, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Create Account";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(49, 121);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(197, 115);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter password again:";
            // 
            // enterPwdAgain
            // 
            this.enterPwdAgain.Location = new System.Drawing.Point(199, 150);
            this.enterPwdAgain.Name = "enterPwdAgain";
            this.enterPwdAgain.Size = new System.Drawing.Size(100, 22);
            this.enterPwdAgain.TabIndex = 6;
            this.enterPwdAgain.TextChanged += new System.EventHandler(this.enterPwdAgain_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountTypeComboBox);
            this.groupBox1.Controls.Add(this.accountType);
            this.groupBox1.Controls.Add(this.enterPwdAgain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Location = new System.Drawing.Point(194, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 294);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Participant",
            "Speaker",
            "Organizer"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(199, 85);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(100, 24);
            this.accountTypeComboBox.TabIndex = 8;
            this.accountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.accountTypeComboBox_SelectedIndexChanged);
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.Location = new System.Drawing.Point(49, 87);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(87, 16);
            this.accountType.TabIndex = 7;
            this.accountType.Text = "Account type:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterPwdAgain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
    }
}

