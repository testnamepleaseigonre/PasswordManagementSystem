
namespace PasswordManagementSystem.Forms
{
    partial class ChangeEntryDataForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.urlAppBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.moreInfoLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.urlAppLabel = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.generatePassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.Location = new System.Drawing.Point(129, 111);
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.Size = new System.Drawing.Size(180, 20);
            this.moreInfoBox.TabIndex = 17;
            // 
            // urlAppBox
            // 
            this.urlAppBox.Location = new System.Drawing.Point(129, 84);
            this.urlAppBox.Name = "urlAppBox";
            this.urlAppBox.Size = new System.Drawing.Size(180, 20);
            this.urlAppBox.TabIndex = 16;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(129, 58);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 20);
            this.passwordBox.TabIndex = 15;
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(129, 32);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(180, 20);
            this.loginNameBox.TabIndex = 14;
            // 
            // moreInfoLabel
            // 
            this.moreInfoLabel.AutoSize = true;
            this.moreInfoLabel.Location = new System.Drawing.Point(38, 114);
            this.moreInfoLabel.Name = "moreInfoLabel";
            this.moreInfoLabel.Size = new System.Drawing.Size(86, 13);
            this.moreInfoLabel.TabIndex = 13;
            this.moreInfoLabel.Text = "More Information";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(70, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // urlAppLabel
            // 
            this.urlAppLabel.AutoSize = true;
            this.urlAppLabel.Location = new System.Drawing.Point(38, 86);
            this.urlAppLabel.Name = "urlAppLabel";
            this.urlAppLabel.Size = new System.Drawing.Size(85, 13);
            this.urlAppLabel.TabIndex = 11;
            this.urlAppLabel.Text = "URL/application";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(61, 35);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(62, 13);
            this.loginNameLabel.TabIndex = 10;
            this.loginNameLabel.Text = "Login name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(234, 137);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generatePassButton
            // 
            this.generatePassButton.Location = new System.Drawing.Point(153, 137);
            this.generatePassButton.Name = "generatePassButton";
            this.generatePassButton.Size = new System.Drawing.Size(75, 23);
            this.generatePassButton.TabIndex = 19;
            this.generatePassButton.Text = "Generate password";
            this.generatePassButton.UseVisualStyleBackColor = true;
            this.generatePassButton.Click += new System.EventHandler(this.generatePassButton_Click);
            // 
            // ChangeEntryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 201);
            this.Controls.Add(this.generatePassButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moreInfoBox);
            this.Controls.Add(this.urlAppBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.moreInfoLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.urlAppLabel);
            this.Controls.Add(this.loginNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeEntryDataForm";
            this.Text = "ChangeEntryDataForm";
            this.Load += new System.EventHandler(this.ChangeEntryDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moreInfoBox;
        private System.Windows.Forms.TextBox urlAppBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.Label moreInfoLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label urlAppLabel;
        private System.Windows.Forms.Label loginNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generatePassButton;
    }
}