namespace Pennies_for_Pay
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
            this.daysPromptLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.payListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // daysPromptLabel
            // 
            this.daysPromptLabel.AutoSize = true;
            this.daysPromptLabel.Location = new System.Drawing.Point(104, 80);
            this.daysPromptLabel.Name = "daysPromptLabel";
            this.daysPromptLabel.Size = new System.Drawing.Size(279, 17);
            this.daysPromptLabel.TabIndex = 0;
            this.daysPromptLabel.Text = "Enter the number of days you plan to work:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(188, 123);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 22);
            this.daysTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(164, 190);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(149, 96);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // payListBox
            // 
            this.payListBox.FormattingEnabled = true;
            this.payListBox.ItemHeight = 16;
            this.payListBox.Location = new System.Drawing.Point(460, 142);
            this.payListBox.Name = "payListBox";
            this.payListBox.Size = new System.Drawing.Size(373, 292);
            this.payListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 519);
            this.Controls.Add(this.payListBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.daysPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysPromptLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox payListBox;
    }
}

