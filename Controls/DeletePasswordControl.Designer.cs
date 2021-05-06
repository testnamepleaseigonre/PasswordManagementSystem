
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePasswordbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(256, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 23);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Login name";
            // 
            // deletePasswordbutton
            // 
            this.deletePasswordbutton.Location = new System.Drawing.Point(472, 78);
            this.deletePasswordbutton.Name = "deletePasswordbutton";
            this.deletePasswordbutton.Size = new System.Drawing.Size(102, 23);
            this.deletePasswordbutton.TabIndex = 42;
            this.deletePasswordbutton.Text = "Delete";
            this.deletePasswordbutton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 186);
            this.listBox1.TabIndex = 41;
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(187, 4);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(107, 23);
            this.searchByNameButton.TabIndex = 40;
            this.searchByNameButton.Text = "Search by name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(106, 4);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 39;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Find password";
            // 
            // DeletePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletePasswordbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.label1);
            this.Name = "DeletePasswordControl";
            this.Size = new System.Drawing.Size(625, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletePasswordbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Label label1;
    }
}
