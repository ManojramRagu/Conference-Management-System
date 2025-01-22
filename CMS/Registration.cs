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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //private void Registration_Load(object sender, EventArgs e)
        //{
        //    // Add account types to the ComboBox
        //    accountTypeComboBox.Items.Add("Admin");
        //    accountTypeComboBox.Items.Add("User");
        //    accountTypeComboBox.Items.Add("Guest");
        //}

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = PasswordBox.Text;
            string confirmPassword = enterPwdAgain.Text;

            // Check if an account type is selected and handle accordingly
            if (accountTypeComboBox.SelectedItem != null)
            {
                string accountType = accountTypeComboBox.SelectedItem.ToString();
                User user = new User();
                user.RegisterUser(username, password, confirmPassword, accountType);
            }
            else
            {
                MessageBox.Show("Please select an account type.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle any text changes if necessary
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click events if needed
        }

        private void enterPwdAgain_TextChanged(object sender, EventArgs e)
        {
            // Handle any text changes in the confirm password field if necessary
        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection changes if needed (for validation or updates)
        }
    }
}
