using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManagementSystem.Models;
using PasswordManagementSystem.Repositories;
using PasswordManagementSystem.Encryption;

namespace PasswordManagementSystem
{
    public partial class RegisterWindow : Form
    {
        private static UsersRepository usersRepository = new UsersRepository();
        private static AESEncryptor encryptor = new AESEncryptor();
        private string filePath = "C:/Users/valde/source/repos/PasswordManagementSystem/Files/";

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void signInLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Closed += (s, args) => this.Close();
            lw.ShowDialog();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxesDataValidation(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text);
                NewUser newUser = new NewUser(usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString());
                usersRepository.register(newUser);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBoxesDataValidation(string us, string pass, string cpass)
        {
            textCheck("Username", us);
            textCheck("Password", pass);
            passwordsMatch(pass, cpass);
        }

        private void textCheck(string boxName, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception($"{boxName} field is empty!");
            if (value.Contains(" ") == true)
                throw new Exception($"{boxName} can't contain whitespaces!");
            if(value.Length < 6)
                throw new Exception($"{boxName} can not have less than 6 characters!");
            if (value.Length > 16)
                throw new Exception($"{boxName} can not exceed 16 characters!");
        }

        private void passwordsMatch(string pass, string cpass)
        {
            if(string.Equals(pass, cpass) != true)
                throw new Exception("Passwords don't match!");
        }
    }
}
