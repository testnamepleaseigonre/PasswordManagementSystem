using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManagementSystem.Forms;

namespace PasswordManagementSystem
{
    public partial class LoginWindow : Form
    {
        private HomePage homePage;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (homePage == null)
                homePage = new HomePage();
            homePage.Closed += (s, args) => this.Show();
            homePage.ShowDialog();
        }
    }
}
