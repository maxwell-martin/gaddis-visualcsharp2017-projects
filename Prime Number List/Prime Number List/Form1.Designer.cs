namespace Prime_Number_List
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.primeNumbersGroupBox = new System.Windows.Forms.GroupBox();
            this.primeNumbersListBox = new System.Windows.Forms.ListBox();
            this.primeNumbersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(174, 28);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 34);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // primeNumbersGroupBox
            // 
            this.primeNumbersGroupBox.Controls.Add(this.primeNumbersListBox);
            this.primeNumbersGroupBox.Location = new System.Drawing.Point(12, 82);
            this.primeNumbersGroupBox.Name = "primeNumbersGroupBox";
            this.primeNumbersGroupBox.Size = new System.Drawing.Size(438, 278);
            this.primeNumbersGroupBox.TabIndex = 1;
            this.primeNumbersGroupBox.TabStop = false;
            this.primeNumbersGroupBox.Text = "All prime numbers from 1-100:";
            // 
            // primeNumbersListBox
            // 
            this.primeNumbersListBox.FormattingEnabled = true;
            this.primeNumbersListBox.ItemHeight = 16;
            this.primeNumbersListBox.Location = new System.Drawing.Point(6, 27);
            this.primeNumbersListBox.MultiColumn = true;
            this.primeNumbersListBox.Name = "primeNumbersListBox";
            this.primeNumbersListBox.Size = new System.Drawing.Size(426, 228);
            this.primeNumbersListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 371);
            this.Controls.Add(this.primeNumbersGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Prime Number List";
            this.primeNumbersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox primeNumbersGroupBox;
        private System.Windows.Forms.ListBox primeNumbersListBox;
    }
}

