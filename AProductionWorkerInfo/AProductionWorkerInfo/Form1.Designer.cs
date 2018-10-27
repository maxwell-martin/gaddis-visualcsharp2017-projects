namespace AProductionWorkerInfo
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
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.employeeNumberPromptLabel = new System.Windows.Forms.Label();
            this.shiftNumberPromptLabel = new System.Windows.Forms.Label();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.shiftNumberTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(147, 79);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(49, 17);
            this.namePromptLabel.TabIndex = 0;
            this.namePromptLabel.Text = "Name:";
            // 
            // employeeNumberPromptLabel
            // 
            this.employeeNumberPromptLabel.AutoSize = true;
            this.employeeNumberPromptLabel.Location = new System.Drawing.Point(68, 136);
            this.employeeNumberPromptLabel.Name = "employeeNumberPromptLabel";
            this.employeeNumberPromptLabel.Size = new System.Drawing.Size(128, 17);
            this.employeeNumberPromptLabel.TabIndex = 1;
            this.employeeNumberPromptLabel.Text = "Employee Number:";
            // 
            // shiftNumberPromptLabel
            // 
            this.shiftNumberPromptLabel.AutoSize = true;
            this.shiftNumberPromptLabel.Location = new System.Drawing.Point(102, 199);
            this.shiftNumberPromptLabel.Name = "shiftNumberPromptLabel";
            this.shiftNumberPromptLabel.Size = new System.Drawing.Size(94, 17);
            this.shiftNumberPromptLabel.TabIndex = 2;
            this.shiftNumberPromptLabel.Text = "Shift Number:";
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(81, 266);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(115, 17);
            this.hourlyPayRatePromptLabel.TabIndex = 3;
            this.hourlyPayRatePromptLabel.Text = "Hourly Pay Rate:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(245, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(245, 131);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.employeeNumberTextBox.TabIndex = 5;
            // 
            // shiftNumberTextBox
            // 
            this.shiftNumberTextBox.Location = new System.Drawing.Point(245, 194);
            this.shiftNumberTextBox.Name = "shiftNumberTextBox";
            this.shiftNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.shiftNumberTextBox.TabIndex = 6;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(245, 261);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.hourlyPayRateTextBox.TabIndex = 7;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(160, 328);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(112, 68);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create Worker";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 429);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.shiftNumberTextBox);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.shiftNumberPromptLabel);
            this.Controls.Add(this.employeeNumberPromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "Form1";
            this.Text = "Production Worker Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label employeeNumberPromptLabel;
        private System.Windows.Forms.Label shiftNumberPromptLabel;
        private System.Windows.Forms.Label hourlyPayRatePromptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox shiftNumberTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Button createButton;
    }
}

