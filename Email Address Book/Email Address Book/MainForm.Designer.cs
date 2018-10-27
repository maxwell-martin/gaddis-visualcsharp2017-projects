namespace Email_Address_Book
{
    partial class MainForm
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
            this.contactsLabel = new System.Windows.Forms.Label();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Location = new System.Drawing.Point(126, 39);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Size = new System.Drawing.Size(63, 17);
            this.contactsLabel.TabIndex = 0;
            this.contactsLabel.Text = "Contacts";
            // 
            // contactsListBox
            // 
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.ItemHeight = 16;
            this.contactsListBox.Location = new System.Drawing.Point(51, 86);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(221, 340);
            this.contactsListBox.TabIndex = 1;
            this.contactsListBox.SelectedIndexChanged += new System.EventHandler(this.contactsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 485);
            this.Controls.Add(this.contactsListBox);
            this.Controls.Add(this.contactsLabel);
            this.Name = "MainForm";
            this.Text = "Email Address Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.ListBox contactsListBox;
    }
}

