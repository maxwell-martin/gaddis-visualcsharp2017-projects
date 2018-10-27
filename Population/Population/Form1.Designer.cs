namespace Population
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
            this.organismsPromptLabel = new System.Windows.Forms.Label();
            this.percentIncreasePromptLabel = new System.Windows.Forms.Label();
            this.daysToMultiplyPromptLabel = new System.Windows.Forms.Label();
            this.organismsTextBox = new System.Windows.Forms.TextBox();
            this.percentIncreaseTextBox = new System.Windows.Forms.TextBox();
            this.daysToMultiplyTextBox = new System.Windows.Forms.TextBox();
            this.populationListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // organismsPromptLabel
            // 
            this.organismsPromptLabel.AutoSize = true;
            this.organismsPromptLabel.Location = new System.Drawing.Point(125, 45);
            this.organismsPromptLabel.Name = "organismsPromptLabel";
            this.organismsPromptLabel.Size = new System.Drawing.Size(198, 17);
            this.organismsPromptLabel.TabIndex = 0;
            this.organismsPromptLabel.Text = "Starting number of organisms:";
            // 
            // percentIncreasePromptLabel
            // 
            this.percentIncreasePromptLabel.AutoSize = true;
            this.percentIncreasePromptLabel.Location = new System.Drawing.Point(141, 105);
            this.percentIncreasePromptLabel.Name = "percentIncreasePromptLabel";
            this.percentIncreasePromptLabel.Size = new System.Drawing.Size(182, 17);
            this.percentIncreasePromptLabel.TabIndex = 1;
            this.percentIncreasePromptLabel.Text = "Average daily increase (%):";
            // 
            // daysToMultiplyPromptLabel
            // 
            this.daysToMultiplyPromptLabel.AutoSize = true;
            this.daysToMultiplyPromptLabel.Location = new System.Drawing.Point(141, 171);
            this.daysToMultiplyPromptLabel.Name = "daysToMultiplyPromptLabel";
            this.daysToMultiplyPromptLabel.Size = new System.Drawing.Size(179, 17);
            this.daysToMultiplyPromptLabel.TabIndex = 2;
            this.daysToMultiplyPromptLabel.Text = "Number of days to multiply:";
            // 
            // organismsTextBox
            // 
            this.organismsTextBox.Location = new System.Drawing.Point(376, 42);
            this.organismsTextBox.Name = "organismsTextBox";
            this.organismsTextBox.Size = new System.Drawing.Size(100, 22);
            this.organismsTextBox.TabIndex = 3;
            // 
            // percentIncreaseTextBox
            // 
            this.percentIncreaseTextBox.Location = new System.Drawing.Point(376, 100);
            this.percentIncreaseTextBox.Name = "percentIncreaseTextBox";
            this.percentIncreaseTextBox.Size = new System.Drawing.Size(100, 22);
            this.percentIncreaseTextBox.TabIndex = 4;
            // 
            // daysToMultiplyTextBox
            // 
            this.daysToMultiplyTextBox.Location = new System.Drawing.Point(376, 166);
            this.daysToMultiplyTextBox.Name = "daysToMultiplyTextBox";
            this.daysToMultiplyTextBox.Size = new System.Drawing.Size(100, 22);
            this.daysToMultiplyTextBox.TabIndex = 5;
            // 
            // populationListBox
            // 
            this.populationListBox.FormattingEnabled = true;
            this.populationListBox.ItemHeight = 16;
            this.populationListBox.Location = new System.Drawing.Point(167, 231);
            this.populationListBox.Name = "populationListBox";
            this.populationListBox.Size = new System.Drawing.Size(290, 228);
            this.populationListBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(256, 497);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 51);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 586);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.populationListBox);
            this.Controls.Add(this.daysToMultiplyTextBox);
            this.Controls.Add(this.percentIncreaseTextBox);
            this.Controls.Add(this.organismsTextBox);
            this.Controls.Add(this.daysToMultiplyPromptLabel);
            this.Controls.Add(this.percentIncreasePromptLabel);
            this.Controls.Add(this.organismsPromptLabel);
            this.Name = "Form1";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label organismsPromptLabel;
        private System.Windows.Forms.Label percentIncreasePromptLabel;
        private System.Windows.Forms.Label daysToMultiplyPromptLabel;
        private System.Windows.Forms.TextBox organismsTextBox;
        private System.Windows.Forms.TextBox percentIncreaseTextBox;
        private System.Windows.Forms.TextBox daysToMultiplyTextBox;
        private System.Windows.Forms.ListBox populationListBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

