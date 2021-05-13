using System;
using System.Windows.Forms;
using PasswordManagementSystem.Models;
using PasswordManagementSystem.Encryption;
using PasswordManagementSystem.Forms;

namespace PasswordManagementSystem.Controls
{
    public partial class UpdatePasswordControl : UserControl, IUpdatePassword
    {
        private IHomePage updatable;
        private static AESEncryptor encryptor = new AESEncryptor();

        public UpdatePasswordControl(IHomePage updatable)
        {
            InitializeComponent();
            this.updatable = updatable;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ChangeEntryDataForm form = new ChangeEntryDataForm((Entry)dataGridView1.SelectedRows[0].Tag, this, updatable);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select entry!");
            }
        }

        private void UpdatePasswordControl_Load(object sender, EventArgs e)
        {
            if (updatable.getUserDataList().Count != 0)
                loadGridView();
            else
                emptyListDisableButtons();
        }

        private void loadGridView()
        {
            foreach (Entry entry in updatable.getUserDataList())
            {
                addRowToGridView(entry);
            }
        }

        public void clearAndLoadGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Entry entry in updatable.getUserDataList())
            {
                addRowToGridView(entry);
            }
        }

        private void emptyListDisableButtons()
        {
            emptyLabel.Visible = true;
            searchButton.Enabled = false;
            allButton.Enabled = false;
            updateButton.Enabled = false;
            dataGridView1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void addRowToGridView(Entry entry)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = entry.getLogin();
            row.Cells[1].Value = "Show Password";
            row.Cells[1].Tag = entry;
            row.Cells[2].Value = entry.getUrlApp();
            row.Cells[3].Value = entry.getMore();
            row.Tag = entry;
            dataGridView1.Rows.Add(row);
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadGridView();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView1.Rows.Clear();
                foreach (Entry entry in updatable.getUserDataList())
                {
                    if (entry.getLogin() == textBox1.Text)
                    {
                        addRowToGridView(entry);
                    }
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewSelectedCellCollection cells = dataGridView1.SelectedCells;
                if (cells[0].ColumnIndex == 1 && cells.Count == 1)
                {
                    if (cells[0].Value.ToString() == "Show Password")
                    {
                        dataGridView1[1, cells[0].RowIndex].Value =
                        encryptor.decryptString(((Entry)dataGridView1[1, cells[0].RowIndex].Tag).getPass());
                    }
                    else
                        dataGridView1[1, cells[0].RowIndex].Value = "Show Password";
                }
            }
            catch
            {

            }
        }
    }
}
