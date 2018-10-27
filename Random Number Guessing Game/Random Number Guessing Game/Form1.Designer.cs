namespace Random_Number_Guessing_Game
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.instructionsLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(47, 87);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(531, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "A number (Range: 1-100) has been randomly generated. Try to guess the number.";
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(175, 146);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(230, 17);
            this.instructionsLabel2.TabIndex = 2;
            this.instructionsLabel2.Text = "Guess the number (Range: 1-100):";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(238, 196);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 22);
            this.guessTextBox.TabIndex = 3;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(224, 295);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(133, 60);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // instructionsLabel3
            // 
            this.instructionsLabel3.AutoSize = true;
            this.instructionsLabel3.Location = new System.Drawing.Point(129, 243);
            this.instructionsLabel3.Name = "instructionsLabel3";
            this.instructionsLabel3.Size = new System.Drawing.Size(337, 17);
            this.instructionsLabel3.TabIndex = 5;
            this.instructionsLabel3.Text = "Click \'Check\' to see if you guessed the right number.";
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 489);
            this.Controls.Add(this.instructionsLabel3);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label instructionsLabel3;
    }
}

