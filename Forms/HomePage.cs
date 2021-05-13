using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PasswordManagementSystem.Controls;
using PasswordManagementSystem.Models;
using PasswordManagementSystem.Encryption;

namespace PasswordManagementSystem.Forms
{
    public partial class HomePage : Form, IHomePage
    {
        private static readonly string filePath = "C:/Users/valde/source/repos/PasswordManagementSystem/Files/";
        private NewPasswordControl newPassCtrl;
        public LoggedInUser loggedInUser;
        private List<Entry> userData = null;
        private static AESEncryptor encryptor = new AESEncryptor();

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
                newPassCtrl = new NewPasswordControl(this);
                contentPanel.Controls.Add(newPassCtrl);
            }
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UpdatePasswordControl(this));
        }

        private void findPasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new FindPasswordControl(this));
        }

        private void deletePasswordButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new DeletePasswordControl(this));
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
                    temp[1] = encryptor.changeToUnwantedCharacters(temp[1]);
                    try
                    {
                        userData.Add(new Entry(temp[0], temp[1], temp[2], temp[3]));
                    }
                    catch
                    {
                        userData = null;
                        ongoingFile.Close();
                        MessageBox.Show("File is corrupted, making new one !");
                        File.Create(filePath + loggedInUser.getUsername() + ".txt");
                        fillUserDataList();
                    }
                }
                ongoingFile.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
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

        public void  removeEntry(Entry entry)
        {
            userData.Remove(entry);
        }

        public LoggedInUser getLoggedInUser()
        {
            return loggedInUser;
        }
        public string getFilePath()
        {
            return filePath;
        }
    }
}
