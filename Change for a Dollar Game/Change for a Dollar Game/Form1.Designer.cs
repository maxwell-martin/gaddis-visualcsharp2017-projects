namespace Change_for_a_Dollar_Game
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
            this.penniesPromptLabel = new System.Windows.Forms.Label();
            this.nickelsPromptLabel = new System.Windows.Forms.Label();
            this.dimesPromptLabel = new System.Windows.Forms.Label();
            this.quartersPromptLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.penniesTextBox = new System.Windows.Forms.TextBox();
            this.nickelsTextBox = new System.Windows.Forms.TextBox();
            this.dimesTextBox = new System.Windows.Forms.TextBox();
            this.quartersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // penniesPromptLabel
            // 
            this.penniesPromptLabel.AutoSize = true;
            this.penniesPromptLabel.Location = new System.Drawing.Point(191, 69);
            this.penniesPromptLabel.Name = "penniesPromptLabel";
            this.penniesPromptLabel.Size = new System.Drawing.Size(63, 17);
            this.penniesPromptLabel.TabIndex = 0;
            this.penniesPromptLabel.Text = "Pennies:";
            // 
            // nickelsPromptLabel
            // 
            this.nickelsPromptLabel.AutoSize = true;
            this.nickelsPromptLabel.Location = new System.Drawing.Point(191, 126);
            this.nickelsPromptLabel.Name = "nickelsPromptLabel";
            this.nickelsPromptLabel.Size = new System.Drawing.Size(57, 17);
            this.nickelsPromptLabel.TabIndex = 3;
            this.nickelsPromptLabel.Text = "Nickels:";
            // 
            // dimesPromptLabel
            // 
            this.dimesPromptLabel.AutoSize = true;
            this.dimesPromptLabel.Location = new System.Drawing.Point(191, 184);
            this.dimesPromptLabel.Name = "dimesPromptLabel";
            this.dimesPromptLabel.Size = new System.Drawing.Size(51, 17);
            this.dimesPromptLabel.TabIndex = 4;
            this.dimesPromptLabel.Text = "Dimes:";
            // 
            // quartersPromptLabel
            // 
            this.quartersPromptLabel.AutoSize = true;
            this.quartersPromptLabel.Location = new System.Drawing.Point(191, 250);
            this.quartersPromptLabel.Name = "quartersPromptLabel";
            this.quartersPromptLabel.Size = new System.Drawing.Size(68, 17);
            this.quartersPromptLabel.TabIndex = 6;
            this.quartersPromptLabel.Text = "Quarters:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(251, 316);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(107, 51);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // penniesTextBox
            // 
            this.penniesTextBox.Location = new System.Drawing.Point(333, 66);
            this.penniesTextBox.Name = "penniesTextBox";
            this.penniesTextBox.Size = new System.Drawing.Size(100, 22);
            this.penniesTextBox.TabIndex = 1;
            // 
            // nickelsTextBox
            // 
            this.nickelsTextBox.Location = new System.Drawing.Point(333, 123);
            this.nickelsTextBox.Name = "nickelsTextBox";
            this.nickelsTextBox.Size = new System.Drawing.Size(100, 22);
            this.nickelsTextBox.TabIndex = 2;
            // 
            // dimesTextBox
            // 
            this.dimesTextBox.Location = new System.Drawing.Point(333, 179);
            this.dimesTextBox.Name = "dimesTextBox";
            this.dimesTextBox.Size = new System.Drawing.Size(100, 22);
            this.dimesTextBox.TabIndex = 3;
            // 
            // quartersTextBox
            // 
            this.quartersTextBox.Location = new System.Drawing.Point(333, 245);
            this.quartersTextBox.Name = "quartersTextBox";
            this.quartersTextBox.Size = new System.Drawing.Size(100, 22);
            this.quartersTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 495);
            this.Controls.Add(this.quartersTextBox);
            this.Controls.Add(this.dimesTextBox);
            this.Controls.Add(this.nickelsTextBox);
            this.Controls.Add(this.penniesTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quartersPromptLabel);
            this.Controls.Add(this.dimesPromptLabel);
            this.Controls.Add(this.nickelsPromptLabel);
            this.Controls.Add(this.penniesPromptLabel);
            this.Name = "Form1";
            this.Text = "Change Counting Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label penniesPromptLabel;
        private System.Windows.Forms.Label nickelsPromptLabel;
        private System.Windows.Forms.Label dimesPromptLabel;
        private System.Windows.Forms.Label quartersPromptLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox penniesTextBox;
        private System.Windows.Forms.TextBox nickelsTextBox;
        private System.Windows.Forms.TextBox dimesTextBox;
        private System.Windows.Forms.TextBox quartersTextBox;
    }
}

