using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class LoginPage : Form
    {
        private RegisterWindow registerWindow;
        private LoginWindow loginWindow;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerWindow = new RegisterWindow();
            registerWindow.Closed += (s, args) => this.Show();
            registerWindow.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginWindow = new LoginWindow();
            loginWindow.Closed += (s, args) => this.Show();
            loginWindow.ShowDialog();
        }
    }
}
