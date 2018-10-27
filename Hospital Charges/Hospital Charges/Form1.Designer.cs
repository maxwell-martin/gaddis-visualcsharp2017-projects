namespace Hospital_Charges
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
            this.medicationChargesPromptLabel = new System.Windows.Forms.Label();
            this.surgicalChargesPromptLabel = new System.Windows.Forms.Label();
            this.labFeesPromptLabel = new System.Windows.Forms.Label();
            this.rehabChargesPromptLabel = new System.Windows.Forms.Label();
            this.totalChargesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medicationChargesTextBox = new System.Windows.Forms.TextBox();
            this.surgicalChargesTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.rehabChargesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysPromptLabel
            // 
            this.daysPromptLabel.AutoSize = true;
            this.daysPromptLabel.Location = new System.Drawing.Point(33, 68);
            this.daysPromptLabel.Name = "daysPromptLabel";
            this.daysPromptLabel.Size = new System.Drawing.Size(240, 17);
            this.daysPromptLabel.TabIndex = 0;
            this.daysPromptLabel.Text = "Enter number of days in the hospital:";
            // 
            // medicationChargesPromptLabel
            // 
            this.medicationChargesPromptLabel.AutoSize = true;
            this.medicationChargesPromptLabel.Location = new System.Drawing.Point(100, 120);
            this.medicationChargesPromptLabel.Name = "medicationChargesPromptLabel";
            this.medicationChargesPromptLabel.Size = new System.Drawing.Size(173, 17);
            this.medicationChargesPromptLabel.TabIndex = 1;
            this.medicationChargesPromptLabel.Text = "Enter medication charges:";
            // 
            // surgicalChargesPromptLabel
            // 
            this.surgicalChargesPromptLabel.AutoSize = true;
            this.surgicalChargesPromptLabel.Location = new System.Drawing.Point(119, 175);
            this.surgicalChargesPromptLabel.Name = "surgicalChargesPromptLabel";
            this.surgicalChargesPromptLabel.Size = new System.Drawing.Size(154, 17);
            this.surgicalChargesPromptLabel.TabIndex = 2;
            this.surgicalChargesPromptLabel.Text = "Enter surgical charges:";
            // 
            // labFeesPromptLabel
            // 
            this.labFeesPromptLabel.AutoSize = true;
            this.labFeesPromptLabel.Location = new System.Drawing.Point(173, 223);
            this.labFeesPromptLabel.Name = "labFeesPromptLabel";
            this.labFeesPromptLabel.Size = new System.Drawing.Size(100, 17);
            this.labFeesPromptLabel.TabIndex = 3;
            this.labFeesPromptLabel.Text = "Enter lab fees:";
            // 
            // rehabChargesPromptLabel
            // 
            this.rehabChargesPromptLabel.AutoSize = true;
            this.rehabChargesPromptLabel.Location = new System.Drawing.Point(32, 272);
            this.rehabChargesPromptLabel.Name = "rehabChargesPromptLabel";
            this.rehabChargesPromptLabel.Size = new System.Drawing.Size(241, 17);
            this.rehabChargesPromptLabel.TabIndex = 4;
            this.rehabChargesPromptLabel.Text = "Enter physical rehabilitation charges:";
            // 
            // totalChargesOutputDescriptionLabel
            // 
            this.totalChargesOutputDescriptionLabel.AutoSize = true;
            this.totalChargesOutputDescriptionLabel.Location = new System.Drawing.Point(174, 333);
            this.totalChargesOutputDescriptionLabel.Name = "totalChargesOutputDescriptionLabel";
            this.totalChargesOutputDescriptionLabel.Size = new System.Drawing.Size(99, 17);
            this.totalChargesOutputDescriptionLabel.TabIndex = 5;
            this.totalChargesOutputDescriptionLabel.Text = "Total charges:";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesLabel.Location = new System.Drawing.Point(291, 333);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(100, 22);
            this.totalChargesLabel.TabIndex = 6;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(291, 63);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 22);
            this.daysTextBox.TabIndex = 7;
            // 
            // medicationChargesTextBox
            // 
            this.medicationChargesTextBox.Location = new System.Drawing.Point(291, 115);
            this.medicationChargesTextBox.Name = "medicationChargesTextBox";
            this.medicationChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.medicationChargesTextBox.TabIndex = 8;
            // 
            // surgicalChargesTextBox
            // 
            this.surgicalChargesTextBox.Location = new System.Drawing.Point(291, 170);
            this.surgicalChargesTextBox.Name = "surgicalChargesTextBox";
            this.surgicalChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.surgicalChargesTextBox.TabIndex = 9;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(291, 218);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 22);
            this.labFeesTextBox.TabIndex = 10;
            // 
            // rehabChargesTextBox
            // 
            this.rehabChargesTextBox.Location = new System.Drawing.Point(291, 267);
            this.rehabChargesTextBox.Name = "rehabChargesTextBox";
            this.rehabChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.rehabChargesTextBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(164, 395);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 50);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 457);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rehabChargesTextBox);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.surgicalChargesTextBox);
            this.Controls.Add(this.medicationChargesTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.totalChargesLabel);
            this.Controls.Add(this.totalChargesOutputDescriptionLabel);
            this.Controls.Add(this.rehabChargesPromptLabel);
            this.Controls.Add(this.labFeesPromptLabel);
            this.Controls.Add(this.surgicalChargesPromptLabel);
            this.Controls.Add(this.medicationChargesPromptLabel);
            this.Controls.Add(this.daysPromptLabel);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysPromptLabel;
        private System.Windows.Forms.Label medicationChargesPromptLabel;
        private System.Windows.Forms.Label surgicalChargesPromptLabel;
        private System.Windows.Forms.Label labFeesPromptLabel;
        private System.Windows.Forms.Label rehabChargesPromptLabel;
        private System.Windows.Forms.Label totalChargesOutputDescriptionLabel;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox medicationChargesTextBox;
        private System.Windows.Forms.TextBox surgicalChargesTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox rehabChargesTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

