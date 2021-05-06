
namespace PasswordManagementSystem.Forms
{
    partial class HomePage
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
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.findPasswordButton = new System.Windows.Forms.Button();
            this.deletePasswordButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.Location = new System.Drawing.Point(149, 12);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(102, 23);
            this.newPasswordButton.TabIndex = 0;
            this.newPasswordButton.Text = "New password";
            this.newPasswordButton.UseVisualStyleBackColor = true;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(257, 12);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(101, 23);
            this.updatePasswordButton.TabIndex = 1;
            this.updatePasswordButton.Text = "UpdatePassword";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // findPasswordButton
            // 
            this.findPasswordButton.Location = new System.Drawing.Point(364, 12);
            this.findPasswordButton.Name = "findPasswordButton";
            this.findPasswordButton.Size = new System.Drawing.Size(100, 23);
            this.findPasswordButton.TabIndex = 2;
            this.findPasswordButton.Text = "Find password";
            this.findPasswordButton.UseVisualStyleBackColor = true;
            this.findPasswordButton.Click += new System.EventHandler(this.findPasswordButton_Click);
            // 
            // deletePasswordButton
            // 
            this.deletePasswordButton.Location = new System.Drawing.Point(470, 12);
            this.deletePasswordButton.Name = "deletePasswordButton";
            this.deletePasswordButton.Size = new System.Drawing.Size(100, 23);
            this.deletePasswordButton.TabIndex = 3;
            this.deletePasswordButton.Text = "Delete password";
            this.deletePasswordButton.UseVisualStyleBackColor = true;
            this.deletePasswordButton.Click += new System.EventHandler(this.deletePasswordButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(36, 41);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(645, 290);
            this.contentPanel.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 358);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.deletePasswordButton);
            this.Controls.Add(this.findPasswordButton);
            this.Controls.Add(this.updatePasswordButton);
            this.Controls.Add(this.newPasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newPasswordButton;
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.Button findPasswordButton;
        private System.Windows.Forms.Button deletePasswordButton;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
    }
}