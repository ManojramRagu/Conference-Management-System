using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();
            string confirmPassword = enterPwdAgain.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string account_type = accountTypeComboBox.SelectedItem.ToString();

            User user = new User();
            user.RegisterUser(username, password, confirmPassword, account_type);
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
