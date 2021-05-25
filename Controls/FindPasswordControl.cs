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

namespace PasswordManagementSystem.Controls
{
    public partial class FindPasswordControl : UserControl
    {
        private IHomePage updatable;

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
                    dataGridView1.Rows.Add(entry.getLogin(), entry.getPass(), entry.getUrlApp(), entry.getMore());
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
                dataGridView1.Rows.Add(entry.getLogin(), entry.getPass(), entry.getUrlApp(), entry.getMore());
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
                        dataGridView1.Rows.Add(entry.getLogin(), entry.getPass(), entry.getUrlApp(), entry.getMore());
                    }
                }
            }
        }
    }
}
