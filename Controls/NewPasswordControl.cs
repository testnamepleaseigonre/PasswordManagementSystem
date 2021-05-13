using System;
using System.Windows.Forms;
using System.IO;
using PasswordManagementSystem.Encryption;
using PasswordManagementSystem.Models;

namespace PasswordManagementSystem.Controls
{
    public partial class NewPasswordControl : UserControl
    {
        private IHomePage updatable;
        private static AESEncryptor encryptor = new AESEncryptor();
        private static Generator generator = new Generator();

        public NewPasswordControl(IHomePage updatable)
        {
            InitializeComponent();
            this.updatable = updatable;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateInput();
                Entry newEntry = new Entry(loginNameBox.Text, encryptor.encryptString(passwordBox.Text), urlAppBox.Text, moreInfoBox.Text);
                updatable.addNewEntry(newEntry);
                string writeToFilePass = encryptor.changeFromUnwantedCharacters(newEntry.getPass());
                File.AppendAllText($"{updatable.getFilePath() + updatable.getLoggedInUser().getUsername()}.txt",
                    $"{newEntry.getLogin()},{writeToFilePass},{newEntry.getUrlApp()},{newEntry.getMore()}\n");
                MessageBox.Show("New password has been added successfully!");
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

        private void generatePassButton_Click(object sender, EventArgs e)
        {
            passwordBox.Text = generator.generatePassword(8);
        }
    }
}
