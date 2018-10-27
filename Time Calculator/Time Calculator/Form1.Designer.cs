namespace Time_Calculator
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
            this.secondsPromptLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondsPromptLabel
            // 
            this.secondsPromptLabel.AutoSize = true;
            this.secondsPromptLabel.Location = new System.Drawing.Point(181, 142);
            this.secondsPromptLabel.Name = "secondsPromptLabel";
            this.secondsPromptLabel.Size = new System.Drawing.Size(67, 17);
            this.secondsPromptLabel.TabIndex = 0;
            this.secondsPromptLabel.Text = "Seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(254, 137);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(197, 22);
            this.secondsTextBox.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(181, 37);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(270, 77);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "This program allows you to enter any number of seconds (greater than or equal to " +
    "60) and will tell you the equivalent value for either minutes, hours, or days.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(266, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 54);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.secondsPromptLabel);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsPromptLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

