namespace Distance_Calculator
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
            this.speedPromptLabel = new System.Windows.Forms.Label();
            this.hoursPromptLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.distancesListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedPromptLabel
            // 
            this.speedPromptLabel.AutoSize = true;
            this.speedPromptLabel.Location = new System.Drawing.Point(136, 55);
            this.speedPromptLabel.Name = "speedPromptLabel";
            this.speedPromptLabel.Size = new System.Drawing.Size(152, 17);
            this.speedPromptLabel.TabIndex = 0;
            this.speedPromptLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursPromptLabel
            // 
            this.hoursPromptLabel.AutoSize = true;
            this.hoursPromptLabel.Location = new System.Drawing.Point(178, 115);
            this.hoursPromptLabel.Name = "hoursPromptLabel";
            this.hoursPromptLabel.Size = new System.Drawing.Size(110, 17);
            this.hoursPromptLabel.TabIndex = 1;
            this.hoursPromptLabel.Text = "Hours Traveled:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(308, 50);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 22);
            this.speedTextBox.TabIndex = 1;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(308, 110);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.hoursTextBox.TabIndex = 2;
            // 
            // distancesListBox
            // 
            this.distancesListBox.FormattingEnabled = true;
            this.distancesListBox.ItemHeight = 16;
            this.distancesListBox.Location = new System.Drawing.Point(112, 175);
            this.distancesListBox.Name = "distancesListBox";
            this.distancesListBox.Size = new System.Drawing.Size(368, 244);
            this.distancesListBox.TabIndex = 0;
            this.distancesListBox.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 468);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(99, 41);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(333, 468);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(592, 538);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.distancesListBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.hoursPromptLabel);
            this.Controls.Add(this.speedPromptLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedPromptLabel;
        private System.Windows.Forms.Label hoursPromptLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.ListBox distancesListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

