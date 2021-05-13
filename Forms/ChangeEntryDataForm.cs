using PasswordManagementSystem.Models;
using PasswordManagementSystem.Encryption;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace PasswordManagementSystem.Forms
{
    public partial class ChangeEntryDataForm : Form
    {
        private static Generator generator = new Generator();
        private static AESEncryptor encryptor = new AESEncryptor();
        private Entry oldEntry;
        private IHomePage updatableHomePage;
        private IUpdatePassword updatableNew;

        public ChangeEntryDataForm()
        {
            InitializeComponent();
        }

        public ChangeEntryDataForm(Entry entry, IUpdatePassword updatableNew, IHomePage updatableHomepage)
        {
            InitializeComponent();
            this.oldEntry = entry;
            this.updatableNew = updatableNew;
            this.updatableHomePage = updatableHomepage;
        }

        private void ChangeEntryDataForm_Load(object sender, EventArgs e)
        {
            loginNameBox.Text = oldEntry.getLogin();
            //passwordBox.Text = entry.getPass();
            urlAppBox.Text = oldEntry.getUrlApp();
            moreInfoBox.Text = oldEntry.getMore();
        }

        private void generatePassButton_Click(object sender, EventArgs e)
        {
            passwordBox.Text = generator.generatePassword(8);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateInput();
                Entry newEntry = new Entry(loginNameBox.Text, encryptor.encryptString(passwordBox.Text), urlAppBox.Text, moreInfoBox.Text);
                makeChangedToList(newEntry);
                makeChangesToFile(newEntry);
                updatableNew.clearAndLoadGrid();
                this.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void validateInput()
        {
            if (String.IsNullOrWhiteSpace(loginNameBox.Text))
                throw new Exception($"{loginNameLabel.Text} field is empty!");
            if (String.IsNullOrWhiteSpace(passwordBox.Text))
                throw new Exception($"{passwordLabel.Text} field is empty!");
            if (String.IsNullOrWhiteSpace(urlAppBox.Text))
                throw new Exception($"{urlAppLabel.Text} field is empty!");
            if (String.IsNullOrWhiteSpace(moreInfoBox.Text))
                throw new Exception($"{moreInfoLabel.Text} field is empty!");
        }

        private void makeChangesToFile(Entry newEntry)
        {
            //remove
            var logList = new List<string>(
                File.ReadAllLines($"{updatableHomePage.getFilePath() + updatableHomePage.getLoggedInUser().getUsername()}.txt"));
            logList.Remove(encryptor
                .changeFromUnwantedCharacters(oldEntry.toString()));
            File.WriteAllLines($"{updatableHomePage.getFilePath() + updatableHomePage.getLoggedInUser().getUsername()}.txt", logList);
            //write
            string writeToFilePass = encryptor.changeFromUnwantedCharacters(newEntry.getPass());
            File.AppendAllText($"{updatableHomePage.getFilePath() + updatableHomePage.getLoggedInUser().getUsername()}.txt",
                $"{newEntry.getLogin()},{writeToFilePass},{newEntry.getUrlApp()},{newEntry.getMore()}\n");
        }

        private void makeChangedToList(Entry newEntry)
        {
            updatableHomePage.removeEntry(oldEntry);
            updatableHomePage.addNewEntry(newEntry);
        }
    }
}
