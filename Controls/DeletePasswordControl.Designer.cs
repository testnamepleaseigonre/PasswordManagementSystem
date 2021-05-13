
namespace PasswordManagementSystem.Controls
{
    partial class DeletePasswordControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePasswordbutton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.deletePassDataGridView = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.more = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deletePassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(251, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 23);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(76, 74);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(169, 20);
            this.loginNameBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Login name";
            // 
            // deletePasswordbutton
            // 
            this.deletePasswordbutton.Location = new System.Drawing.Point(520, 72);
            this.deletePasswordbutton.Name = "deletePasswordbutton";
            this.deletePasswordbutton.Size = new System.Drawing.Size(102, 23);
            this.deletePasswordbutton.TabIndex = 42;
            this.deletePasswordbutton.Text = "Delete";
            this.deletePasswordbutton.UseVisualStyleBackColor = true;
            this.deletePasswordbutton.Click += new System.EventHandler(this.deletePasswordbutton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(359, 72);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 39;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Delete password";
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Location = new System.Drawing.Point(465, 9);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(157, 13);
            this.emptyLabel.TabIndex = 46;
            this.emptyLabel.Text = "No data found! Try adding new!";
            this.emptyLabel.Visible = false;
            // 
            // deletePassDataGridView
            // 
            this.deletePassDataGridView.AllowUserToAddRows = false;
            this.deletePassDataGridView.AllowUserToDeleteRows = false;
            this.deletePassDataGridView.AllowUserToResizeRows = false;
            this.deletePassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletePassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.url,
            this.more});
            this.deletePassDataGridView.Location = new System.Drawing.Point(3, 101);
            this.deletePassDataGridView.Name = "deletePassDataGridView";
            this.deletePassDataGridView.ReadOnly = true;
            this.deletePassDataGridView.Size = new System.Drawing.Size(619, 186);
            this.deletePassDataGridView.TabIndex = 47;
            this.deletePassDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.deletePassDataGridView_MouseDoubleClick);
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 154;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 154;
            // 
            // url
            // 
            this.url.HeaderText = "URL / Application";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 154;
            // 
            // more
            // 
            this.more.HeaderText = "More Info.";
            this.more.Name = "more";
            this.more.ReadOnly = true;
            this.more.Width = 154;
            // 
            // DeletePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deletePassDataGridView);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletePasswordbutton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.label1);
            this.Name = "DeletePasswordControl";
            this.Size = new System.Drawing.Size(625, 290);
            this.Load += new System.EventHandler(this.DeletePasswordControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletePassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletePasswordbutton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.DataGridView deletePassDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn more;
    }
}
