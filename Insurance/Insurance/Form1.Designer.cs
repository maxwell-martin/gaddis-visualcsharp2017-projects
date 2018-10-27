namespace Insurance
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
            this.buildingCostPromptLabel = new System.Windows.Forms.Label();
            this.buildingAmountTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildingCostPromptLabel
            // 
            this.buildingCostPromptLabel.AutoSize = true;
            this.buildingCostPromptLabel.Location = new System.Drawing.Point(53, 68);
            this.buildingCostPromptLabel.Name = "buildingCostPromptLabel";
            this.buildingCostPromptLabel.Size = new System.Drawing.Size(275, 17);
            this.buildingCostPromptLabel.TabIndex = 0;
            this.buildingCostPromptLabel.Text = "Enter the replacement cost of the building:";
            // 
            // buildingAmountTextBox
            // 
            this.buildingAmountTextBox.Location = new System.Drawing.Point(457, 63);
            this.buildingAmountTextBox.Name = "buildingAmountTextBox";
            this.buildingAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.buildingAmountTextBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(53, 178);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(349, 17);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Minimum amount of insurance suggested to purchase:";
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insuranceLabel.Location = new System.Drawing.Point(457, 167);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(100, 39);
            this.insuranceLabel.TabIndex = 3;
            this.insuranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(290, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 50);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.insuranceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.buildingAmountTextBox);
            this.Controls.Add(this.buildingCostPromptLabel);
            this.Name = "Form1";
            this.Text = "Insurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buildingCostPromptLabel;
        private System.Windows.Forms.TextBox buildingAmountTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

