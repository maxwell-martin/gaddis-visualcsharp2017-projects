namespace Random_Number_File_Reader
{
    partial class Form1
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.numbersGroupBox = new System.Windows.Forms.GroupBox();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.numbersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(105, 33);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(294, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Click the open button to choose a file to read.";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(195, 74);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(111, 43);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // numbersGroupBox
            // 
            this.numbersGroupBox.Controls.Add(this.numbersListBox);
            this.numbersGroupBox.Location = new System.Drawing.Point(30, 144);
            this.numbersGroupBox.Name = "numbersGroupBox";
            this.numbersGroupBox.Size = new System.Drawing.Size(467, 219);
            this.numbersGroupBox.TabIndex = 2;
            this.numbersGroupBox.TabStop = false;
            this.numbersGroupBox.Text = "Numbers Reader";
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.ItemHeight = 16;
            this.numbersListBox.Location = new System.Drawing.Point(6, 21);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.numbersListBox.Size = new System.Drawing.Size(455, 196);
            this.numbersListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 395);
            this.Controls.Add(this.numbersGroupBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Random Number File Reader";
            this.numbersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox numbersGroupBox;
        private System.Windows.Forms.ListBox numbersListBox;
    }
}

