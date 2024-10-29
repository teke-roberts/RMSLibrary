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
using RMSLibrary;

namespace RMS_UI
{
    public partial class NewAccountForm : Form
    {
        private string hashedPass = "";
        public NewAccountForm()
        {
            InitializeComponent();
        }
        
        //TODO - add check box to show passwords, hide passwords

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //TODO - check if username exists
                hashedPass = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
                AccountModel acc = new AccountModel(usernameTextBox.Text, hashedPass, isAdmin());
                GlobalConfig.Cnn.AddNewAccount(acc);
                this.Close();
            }
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            reenterpasswordTextBox.Text = "";
            isAdminBox.Checked = false;
        }

        public string isAdmin()
        {
            if (isAdminBox.Checked)
            {
                return "admin";
            }
            else
            {
                return "user";
            }
        }

        public bool ValidateInput()
        {
            bool isValid = true;

            string userName = usernameTextBox.Text;

            foreach (char c in userName)
            {
                if (!(Char.IsLetterOrDigit(c) || Char.IsPunctuation(c)))
                {
                    isValid = false;
                }
            }
            if (userName.Length <= 0 || userName.Length > 50)
            {
                isValid = false;
            }

            string userPass = passwordTextBox.Text;

            foreach (char c in userPass)
            {
                if (!(Char.IsLetterOrDigit(c) || Char.IsPunctuation(c)))
                {
                    isValid = false;
                }
            }
            if (userPass.Length <= 0 || userPass.Length > 50)
            {
                isValid = false;
            }

            string rePass = reenterpasswordTextBox.Text;

            if(rePass != userPass)
            {
                isValid = false;
            }

            return isValid;
        }

        
    }
}
