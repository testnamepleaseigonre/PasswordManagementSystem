using System;
using System.Windows.Forms;
using PasswordManagementSystem.Models;
using PasswordManagementSystem.Encryption;
using System.IO;
using System.Collections.Generic;

namespace PasswordManagementSystem.Controls
{
    public partial class DeletePasswordControl : UserControl
    {
        private IHomePage updatable;
        private static AESEncryptor encryptor = new AESEncryptor();

        public DeletePasswordControl(IHomePage updatable)
        {
            InitializeComponent();
            this.updatable = updatable;
        }

        private void DeletePasswordControl_Load(object sender, EventArgs e)
        {
            if (updatable.getUserDataList().Count != 0)
                loadGridView();
            else
                emptyListDisableButtons();
        }

        private void emptyListDisableButtons()
        {
            emptyLabel.Visible = true;
            searchButton.Enabled = false;
            deletePasswordbutton.Enabled = false;
            allButton.Enabled = false;
            loginNameBox.Enabled = false;
            deletePassDataGridView.Enabled = false;
        }

        private void loadGridView()
        {
            foreach (Entry entry in updatable.getUserDataList())
            {
                addRowToGridView(entry);
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            deletePassDataGridView.Rows.Clear();
            loadGridView();
        }

        private void deletePassDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewSelectedCellCollection cells = deletePassDataGridView.SelectedCells;
                if (cells[0].ColumnIndex == 1 && cells.Count == 1)
                {
                    if (cells[0].Value.ToString() == "Show Password")
                    {
                        deletePassDataGridView[1, cells[0].RowIndex].Value =
                        encryptor.decryptString(((Entry)deletePassDataGridView[1, cells[0].RowIndex].Tag).getPass());
                    }
                    else
                        deletePassDataGridView[1, cells[0].RowIndex].Value = "Show Password";
                }
            }
            catch
            {

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginNameBox.Text) && !String.IsNullOrWhiteSpace(loginNameBox.Text))
            {
                deletePassDataGridView.Rows.Clear();
                foreach (Entry entry in updatable.getUserDataList())
                {
                    if (entry.getLogin() == loginNameBox.Text)
                    {
                        addRowToGridView(entry);
                    }
                }
            }
        }

        private void addRowToGridView(Entry entry)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(deletePassDataGridView);
            row.Cells[0].Value = entry.getLogin();
            row.Cells[1].Value = "Show Password";
            row.Cells[1].Tag = entry;
            row.Cells[2].Value = entry.getUrlApp();
            row.Cells[3].Value = entry.getMore();
            row.Tag = entry;
            deletePassDataGridView.Rows.Add(row);
        }

        private void deletePasswordbutton_Click(object sender, EventArgs e)
        {
            if(deletePassDataGridView.SelectedRows.Count != 0)
            {
                int selectedRows = deletePassDataGridView.SelectedRows.Count;
                foreach (DataGridViewRow item in this.deletePassDataGridView.SelectedRows)
                {
                    deleteEntry((Entry)item.Tag, item.Index);
                }
                if (selectedRows == 1)
                    MessageBox.Show("Entry succesfully deleted!");
                else
                    MessageBox.Show("Entries succesfully deleted!");
            }
        }

        private void deleteEntry(Entry entry, int index)
        {
            deleteEntryFromFile(entry);
            updatable.removeEntry(entry);
            deletePassDataGridView.Rows.RemoveAt(index);
            if (updatable.getUserDataList().Count == 0)
                emptyListDisableButtons();
        }

        private void deleteEntryFromFile(Entry entry)
        {
            var logList = new List<string>(
                File.ReadAllLines($"{updatable.getFilePath() + updatable.getLoggedInUser().getUsername()}.txt"));
            logList.Remove(encryptor
                .changeFromUnwantedCharacters(entry.toString()));
            File.WriteAllLines($"{updatable.getFilePath() + updatable.getLoggedInUser().getUsername()}.txt", logList);
        }
    }
}
