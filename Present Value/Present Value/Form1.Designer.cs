namespace Present_Value
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
            this.futureValuePromptLabel = new System.Windows.Forms.Label();
            this.annualInterestRatePromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.presentValuePromptLabel = new System.Windows.Forms.Label();
            this.futureValueTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureValuePromptLabel
            // 
            this.futureValuePromptLabel.AutoSize = true;
            this.futureValuePromptLabel.Location = new System.Drawing.Point(102, 68);
            this.futureValuePromptLabel.Name = "futureValuePromptLabel";
            this.futureValuePromptLabel.Size = new System.Drawing.Size(125, 17);
            this.futureValuePromptLabel.TabIndex = 0;
            this.futureValuePromptLabel.Text = "Enter future value:";
            // 
            // annualInterestRatePromptLabel
            // 
            this.annualInterestRatePromptLabel.AutoSize = true;
            this.annualInterestRatePromptLabel.Location = new System.Drawing.Point(28, 114);
            this.annualInterestRatePromptLabel.Name = "annualInterestRatePromptLabel";
            this.annualInterestRatePromptLabel.Size = new System.Drawing.Size(199, 17);
            this.annualInterestRatePromptLabel.TabIndex = 1;
            this.annualInterestRatePromptLabel.Text = "Enter annual interest rate (%):";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.Location = new System.Drawing.Point(52, 160);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(175, 56);
            this.yearsPromptLabel.TabIndex = 2;
            this.yearsPromptLabel.Text = "Enter the total number of years you plan on leaving the money in the account:\r\n";
            // 
            // presentValuePromptLabel
            // 
            this.presentValuePromptLabel.Location = new System.Drawing.Point(68, 243);
            this.presentValuePromptLabel.Name = "presentValuePromptLabel";
            this.presentValuePromptLabel.Size = new System.Drawing.Size(159, 58);
            this.presentValuePromptLabel.TabIndex = 3;
            this.presentValuePromptLabel.Text = "Amount you need to put in the savings account to meet your goals:";
            this.presentValuePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // futureValueTextBox
            // 
            this.futureValueTextBox.Location = new System.Drawing.Point(248, 63);
            this.futureValueTextBox.Name = "futureValueTextBox";
            this.futureValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.futureValueTextBox.TabIndex = 4;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(248, 111);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.annualInterestRateTextBox.TabIndex = 5;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(248, 177);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearsTextBox.TabIndex = 6;
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentValueLabel.Location = new System.Drawing.Point(245, 264);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(100, 22);
            this.presentValueLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(164, 340);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 37);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 405);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.presentValueLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.futureValueTextBox);
            this.Controls.Add(this.presentValuePromptLabel);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.annualInterestRatePromptLabel);
            this.Controls.Add(this.futureValuePromptLabel);
            this.Name = "Form1";
            this.Text = "Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValuePromptLabel;
        private System.Windows.Forms.Label annualInterestRatePromptLabel;
        private System.Windows.Forms.Label yearsPromptLabel;
        private System.Windows.Forms.Label presentValuePromptLabel;
        private System.Windows.Forms.TextBox futureValueTextBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label presentValueLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

