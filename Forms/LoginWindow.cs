using System;
using System.Windows.Forms;
using PasswordManagementSystem.Forms;
using PasswordManagementSystem.Repositories;
using PasswordManagementSystem.Encryption;
using PasswordManagementSystem.Models;

namespace PasswordManagementSystem
{
    public partial class LoginWindow : Form
    {
        private static readonly string directory = "C:/Users/valde/source/repos/PasswordManagementSystem/Files/";
        private UsersRepository repository = new UsersRepository();
        private static AESEncryptor encryptor = new AESEncryptor();

        public LoginWindow()
        {
            InitializeComponent();
            usernameBox.Text = "jonukas";
            passwordBox.Text = "jonukas";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggedInUser user = repository.login(usernameBox.Text.ToString(), passwordBox.Text.ToString());
                encryptor.decryptFile(directory, user.getUsername());
                HomePage homePage = new HomePage(user);
                this.Hide();
                homePage.Closed += (s, args) => this.Show();
                homePage.Closed += (s, args) => encryptor.encryptFile(directory, user.getUsername());//-------------------
                homePage.ShowDialog();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
