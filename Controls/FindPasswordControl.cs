using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManagementSystem.Models;
using PasswordManagementSystem.Encryption;

namespace PasswordManagementSystem.Controls
{
    public partial class FindPasswordControl : UserControl
    {
        private IHomePage updatable;
        private static AESEncryptor encryptor = new AESEncryptor();

        public FindPasswordControl(IHomePage updatable) 
        {
            InitializeComponent();
            this.updatable = updatable;
        }

        private void FindPasswordControl_Load(object sender, EventArgs e)
        {
            if (updatable.getUserDataList().Count != 0)
            {
                foreach (Entry entry in updatable.getUserDataList())
                {
                    addRowToGrid(entry);
                }
            }
            else
            {
                dataGridView1.Enabled = false;
                emptyLabel.Visible = true;
                textBox1.Enabled = false;
                searchButton.Enabled = false;
                copyPasswordbutton.Enabled = false;
                allButton.Enabled = false;
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Entry entry in updatable.getUserDataList())
            {
                addRowToGrid(entry);
            }
        }

        private void copyPasswordbutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                try
                {
                    Clipboard.SetText(item.Value.ToString());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView1.Rows.Clear();
                foreach (Entry entry in updatable.getUserDataList())
                {
                    if (entry.getLogin() == textBox1.Text)
                    {
                        addRowToGrid(entry);
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

        private void addRowToGrid(Entry entry)
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
    }
}
