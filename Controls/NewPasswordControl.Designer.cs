
namespace PasswordManagementSystem.Controls
{
    partial class NewPasswordControl
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.urlAppLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.moreInfoLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.urlAppBox = new System.Windows.Forms.TextBox();
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(14, 11);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(110, 13);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Create new Password";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(161, 83);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(62, 13);
            this.loginNameLabel.TabIndex = 1;
            this.loginNameLabel.Text = "Login name";
            // 
            // urlAppLabel
            // 
            this.urlAppLabel.AutoSize = true;
            this.urlAppLabel.Location = new System.Drawing.Point(151, 134);
            this.urlAppLabel.Name = "urlAppLabel";
            this.urlAppLabel.Size = new System.Drawing.Size(85, 13);
            this.urlAppLabel.TabIndex = 2;
            this.urlAppLabel.Text = "URL/application";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(161, 110);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // moreInfoLabel
            // 
            this.moreInfoLabel.AutoSize = true;
            this.moreInfoLabel.Location = new System.Drawing.Point(151, 159);
            this.moreInfoLabel.Name = "moreInfoLabel";
            this.moreInfoLabel.Size = new System.Drawing.Size(86, 13);
            this.moreInfoLabel.TabIndex = 4;
            this.moreInfoLabel.Text = "More Information";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(347, 185);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(285, 80);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(137, 20);
            this.loginNameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(285, 106);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(137, 20);
            this.passwordBox.TabIndex = 7;
            // 
            // urlAppBox
            // 
            this.urlAppBox.Location = new System.Drawing.Point(285, 132);
            this.urlAppBox.Name = "urlAppBox";
            this.urlAppBox.Size = new System.Drawing.Size(137, 20);
            this.urlAppBox.TabIndex = 8;
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.Location = new System.Drawing.Point(285, 159);
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.Size = new System.Drawing.Size(137, 20);
            this.moreInfoBox.TabIndex = 9;
            // 
            // NewPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moreInfoBox);
            this.Controls.Add(this.urlAppBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.moreInfoLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.urlAppLabel);
            this.Controls.Add(this.loginNameLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "NewPasswordControl";
            this.Size = new System.Drawing.Size(625, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label loginNameLabel;
        private System.Windows.Forms.Label urlAppLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label moreInfoLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox urlAppBox;
        private System.Windows.Forms.TextBox moreInfoBox;
    }
}
