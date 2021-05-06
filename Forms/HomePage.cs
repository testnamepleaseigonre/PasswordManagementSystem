using System;
using System.Windows.Forms;
using PasswordManagementSystem.Controls;

namespace PasswordManagementSystem.Forms
{
    public partial class HomePage : Form
    {
        private NewPasswordControl newPassCtrl;
        private DeletePasswordControl deletePassCtrl;
        private FindPasswordControl findPassCtrl;
        private UpdatePasswordControl updatePassCtrl;

        public HomePage()
        {
            InitializeComponent();
            newPasswordButton_Click(newPassCtrl, new EventArgs());
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if(newPassCtrl != null)
                contentPanel.Controls.Add(newPassCtrl);
            else
            {
                newPassCtrl = new NewPasswordControl();
                contentPanel.Controls.Add(newPassCtrl);
            }
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if (updatePassCtrl != null)
                contentPanel.Controls.Add(updatePassCtrl);
            else
            {
                updatePassCtrl = new UpdatePasswordControl();
                contentPanel.Controls.Add(updatePassCtrl);
            }
        }

        private void findPasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if (findPassCtrl != null)
                contentPanel.Controls.Add(findPassCtrl);
            else
            {
                findPassCtrl = new FindPasswordControl();
                contentPanel.Controls.Add(findPassCtrl);
            }
        }

        private void deletePasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if (deletePassCtrl != null)
                contentPanel.Controls.Add(deletePassCtrl);
            else
            {
                deletePassCtrl = new DeletePasswordControl();
                contentPanel.Controls.Add(deletePassCtrl);
            }

        }
    }
}
