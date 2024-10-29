using RMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace RMS_UI
{
    public partial class LoginForm : Form
    {
        
        private AccountModel loggedAccount = new AccountModel();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(CheckCredentials())
            {
                WaiterDashboardForm waiterForm = new WaiterDashboardForm(loggedAccount);
                this.Hide();
                waiterForm.ShowDialog();
                this.Close();
            }
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        public bool CheckCredentials()
        {
            loggedAccount = GlobalConfig.Cnn.GetAccount(usernameTextBox.Text);
            if(loggedAccount.accountPassword != "")
            {
                return BCrypt.Net.BCrypt.Verify(passwordTextBox.Text, loggedAccount.accountPassword);
            }
            else
            {
                return false;
            }
            
        }
    }
}
