using System;
using System.Windows.Forms;
using System.IO;
using PasswordManagementSystem.Models;

namespace PasswordManagementSystem.Controls
{
    public partial class NewPasswordControl : UserControl
    {
        private string filePath;
        private LoggedInUser loggedUser;
        private IHomePage updatable;

        public NewPasswordControl(string filePath, LoggedInUser loggedInUser, IHomePage updatable)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.loggedUser = loggedInUser;
            this.updatable = updatable;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newData = $"{loginNameBox.Text},{passwordBox.Text},{urlAppBox.Text},{moreInfoBox.Text}\n";
                string path = $"{filePath}{loggedUser.getUsername()}.txt";
                File.AppendAllText(path, newData);
                Entry newEntry = new Entry(loginNameBox.Text, passwordBox.Text, urlAppBox.Text, moreInfoBox.Text);
                updatable.addNewEntry(newEntry);
                MessageBox.Show("New password has been added successfully!");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
