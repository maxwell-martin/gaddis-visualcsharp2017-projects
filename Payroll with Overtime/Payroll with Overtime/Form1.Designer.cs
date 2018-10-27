namespace Payroll_with_Overtime
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
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 137);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 43);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(120, 137);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 43);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 137);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 43);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "Calculate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(161, 92);
            this.grossPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(133, 28);
            this.grossPayLabel.TabIndex = 23;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(77, 98);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(77, 17);
            this.outputDescriptionLabel.TabIndex = 22;
            this.outputDescriptionLabel.Text = "Gross pay:";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(161, 55);
            this.hourlyPayRateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(132, 22);
            this.hourlyPayRateTextBox.TabIndex = 21;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(161, 18);
            this.hoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(132, 22);
            this.hoursWorkedTextBox.TabIndex = 20;
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(45, 60);
            this.hourlyPayRatePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(109, 17);
            this.hourlyPayRatePromptLabel.TabIndex = 19;
            this.hourlyPayRatePromptLabel.Text = "Hourly pay rate:";
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(52, 22);
            this.hoursWorkedPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(99, 17);
            this.hoursWorkedPromptLabel.TabIndex = 18;
            this.hoursWorkedPromptLabel.Text = "Hours worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 197);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox;
        internal System.Windows.Forms.TextBox hoursWorkedTextBox;
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel;
        internal System.Windows.Forms.Label hoursWorkedPromptLabel;
    }
}

