namespace AShiftSupervisor
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
            this.numberPromptLabel = new System.Windows.Forms.Label();
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.productionAmtPromptLabel = new System.Windows.Forms.Label();
            this.bonusStatusButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.productionAmtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(282, 29);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(49, 17);
            this.namePromptLabel.TabIndex = 0;
            this.namePromptLabel.Text = "Name:";
            // 
            // numberPromptLabel
            // 
            this.numberPromptLabel.AutoSize = true;
            this.numberPromptLabel.Location = new System.Drawing.Point(269, 75);
            this.numberPromptLabel.Name = "numberPromptLabel";
            this.numberPromptLabel.Size = new System.Drawing.Size(62, 17);
            this.numberPromptLabel.TabIndex = 1;
            this.numberPromptLabel.Text = "Number:";
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Location = new System.Drawing.Point(279, 134);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(52, 17);
            this.salaryPromptLabel.TabIndex = 2;
            this.salaryPromptLabel.Text = "Salary:";
            // 
            // productionAmtPromptLabel
            // 
            this.productionAmtPromptLabel.AutoSize = true;
            this.productionAmtPromptLabel.Location = new System.Drawing.Point(26, 197);
            this.productionAmtPromptLabel.Name = "productionAmtPromptLabel";
            this.productionAmtPromptLabel.Size = new System.Drawing.Size(305, 17);
            this.productionAmtPromptLabel.TabIndex = 3;
            this.productionAmtPromptLabel.Text = "Production Amount (How many units created?):";
            // 
            // bonusStatusButton
            // 
            this.bonusStatusButton.Location = new System.Drawing.Point(232, 278);
            this.bonusStatusButton.Name = "bonusStatusButton";
            this.bonusStatusButton.Size = new System.Drawing.Size(127, 60);
            this.bonusStatusButton.TabIndex = 4;
            this.bonusStatusButton.Text = "Bonus Eligibility Status";
            this.bonusStatusButton.UseVisualStyleBackColor = true;
            this.bonusStatusButton.Click += new System.EventHandler(this.bonusStatusButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(356, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(356, 70);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 1;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(356, 129);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // productionAmtTextBox
            // 
            this.productionAmtTextBox.Location = new System.Drawing.Point(356, 192);
            this.productionAmtTextBox.Name = "productionAmtTextBox";
            this.productionAmtTextBox.Size = new System.Drawing.Size(100, 22);
            this.productionAmtTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 407);
            this.Controls.Add(this.productionAmtTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.bonusStatusButton);
            this.Controls.Add(this.productionAmtPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Controls.Add(this.numberPromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "Form1";
            this.Text = "Shift Supervisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label numberPromptLabel;
        private System.Windows.Forms.Label salaryPromptLabel;
        private System.Windows.Forms.Label productionAmtPromptLabel;
        private System.Windows.Forms.Button bonusStatusButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox productionAmtTextBox;
    }
}

