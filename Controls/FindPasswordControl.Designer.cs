
namespace PasswordManagementSystem.Controls
{
    partial class FindPasswordControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.copyPasswordbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find password";
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(189, 4);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(107, 23);
            this.searchByNameButton.TabIndex = 32;
            this.searchByNameButton.Text = "Search by name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(108, 4);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 31;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 186);
            this.listBox1.TabIndex = 33;
            // 
            // copyPasswordbutton
            // 
            this.copyPasswordbutton.Location = new System.Drawing.Point(474, 101);
            this.copyPasswordbutton.Name = "copyPasswordbutton";
            this.copyPasswordbutton.Size = new System.Drawing.Size(102, 23);
            this.copyPasswordbutton.TabIndex = 34;
            this.copyPasswordbutton.Text = "Copy password";
            this.copyPasswordbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Login name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 36;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(258, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 23);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // FindPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copyPasswordbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.label1);
            this.Name = "FindPasswordControl";
            this.Size = new System.Drawing.Size(625, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button copyPasswordbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
    }
}
