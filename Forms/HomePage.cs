using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PasswordManagementSystem.Controls;
using PasswordManagementSystem.Models;

namespace PasswordManagementSystem.Forms
{
    public partial class HomePage : Form, IHomePage
    {
        private static readonly string filePath = "C:/Users/valde/source/repos/PasswordManagementSystem/Files/";
        private NewPasswordControl newPassCtrl;
        private DeletePasswordControl deletePassCtrl;
        private UpdatePasswordControl updatePassCtrl;
        public LoggedInUser loggedInUser;
        private List<Entry> userData = null;

        public HomePage(LoggedInUser user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            newPasswordButton_Click(newPassCtrl, new EventArgs());
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if(newPassCtrl != null)
                contentPanel.Controls.Add(newPassCtrl);
            else
            {
                newPassCtrl = new NewPasswordControl(filePath, loggedInUser, this);
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
            contentPanel.Controls.Add(new FindPasswordControl(this));
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

        private void fillUserDataList()
        {
            try
            {
                userData = new List<Entry>();
                string line;
                string[] temp;
                StreamReader ongoingFile = new StreamReader(filePath + loggedInUser.getUsername() + ".txt");
                while ((line = ongoingFile.ReadLine()) != null)
                {
                    temp = line.Split(',');
                    userData.Add(new Entry(temp[0], temp[1], temp[2], temp[3]));
                }
                ongoingFile.Close();
            }
            catch
            {

            }
        }

        public List<Entry> getUserDataList()
        {
            return userData;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            fillUserDataList();
        }

        public void addNewEntry(Entry newEntry)
        {
            userData.Add(newEntry);
        }

    }
}
