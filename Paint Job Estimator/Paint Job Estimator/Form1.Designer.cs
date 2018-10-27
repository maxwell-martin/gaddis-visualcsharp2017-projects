namespace Paint_Job_Estimator
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
            this.squareFtPromptLabel = new System.Windows.Forms.Label();
            this.paintPricePromptLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.gallonsOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.hoursOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.paintCostOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.laborChargesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalCostOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.sqFtTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squareFtPromptLabel
            // 
            this.squareFtPromptLabel.AutoSize = true;
            this.squareFtPromptLabel.Location = new System.Drawing.Point(28, 28);
            this.squareFtPromptLabel.Name = "squareFtPromptLabel";
            this.squareFtPromptLabel.Size = new System.Drawing.Size(318, 17);
            this.squareFtPromptLabel.TabIndex = 0;
            this.squareFtPromptLabel.Text = "Enter the square feet of wall space to be painted:";
            // 
            // paintPricePromptLabel
            // 
            this.paintPricePromptLabel.AutoSize = true;
            this.paintPricePromptLabel.Location = new System.Drawing.Point(99, 94);
            this.paintPricePromptLabel.Name = "paintPricePromptLabel";
            this.paintPricePromptLabel.Size = new System.Drawing.Size(247, 17);
            this.paintPricePromptLabel.TabIndex = 1;
            this.paintPricePromptLabel.Text = "Enter the price of the paint per gallon:";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsLabel.Location = new System.Drawing.Point(372, 145);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(100, 23);
            this.gallonsLabel.TabIndex = 2;
            // 
            // gallonsOutputDescriptionLabel
            // 
            this.gallonsOutputDescriptionLabel.AutoSize = true;
            this.gallonsOutputDescriptionLabel.Location = new System.Drawing.Point(111, 146);
            this.gallonsOutputDescriptionLabel.Name = "gallonsOutputDescriptionLabel";
            this.gallonsOutputDescriptionLabel.Size = new System.Drawing.Size(235, 17);
            this.gallonsOutputDescriptionLabel.TabIndex = 7;
            this.gallonsOutputDescriptionLabel.Text = "Number of gallons of paint required:";
            // 
            // hoursOutputDescriptionLabel
            // 
            this.hoursOutputDescriptionLabel.AutoSize = true;
            this.hoursOutputDescriptionLabel.Location = new System.Drawing.Point(187, 199);
            this.hoursOutputDescriptionLabel.Name = "hoursOutputDescriptionLabel";
            this.hoursOutputDescriptionLabel.Size = new System.Drawing.Size(159, 17);
            this.hoursOutputDescriptionLabel.TabIndex = 8;
            this.hoursOutputDescriptionLabel.Text = "Hours of labor required:";
            // 
            // paintCostOutputDescriptionLabel
            // 
            this.paintCostOutputDescriptionLabel.AutoSize = true;
            this.paintCostOutputDescriptionLabel.Location = new System.Drawing.Point(221, 263);
            this.paintCostOutputDescriptionLabel.Name = "paintCostOutputDescriptionLabel";
            this.paintCostOutputDescriptionLabel.Size = new System.Drawing.Size(125, 17);
            this.paintCostOutputDescriptionLabel.TabIndex = 9;
            this.paintCostOutputDescriptionLabel.Text = "Total cost of paint:";
            // 
            // laborChargesOutputDescriptionLabel
            // 
            this.laborChargesOutputDescriptionLabel.AutoSize = true;
            this.laborChargesOutputDescriptionLabel.Location = new System.Drawing.Point(221, 312);
            this.laborChargesOutputDescriptionLabel.Name = "laborChargesOutputDescriptionLabel";
            this.laborChargesOutputDescriptionLabel.Size = new System.Drawing.Size(126, 17);
            this.laborChargesOutputDescriptionLabel.TabIndex = 10;
            this.laborChargesOutputDescriptionLabel.Text = "Total cost of labor:";
            // 
            // totalCostOutputDescriptionLabel
            // 
            this.totalCostOutputDescriptionLabel.AutoSize = true;
            this.totalCostOutputDescriptionLabel.Location = new System.Drawing.Point(198, 366);
            this.totalCostOutputDescriptionLabel.Name = "totalCostOutputDescriptionLabel";
            this.totalCostOutputDescriptionLabel.Size = new System.Drawing.Size(148, 17);
            this.totalCostOutputDescriptionLabel.TabIndex = 11;
            this.totalCostOutputDescriptionLabel.Text = "Total cost of paint job:";
            // 
            // sqFtTextBox
            // 
            this.sqFtTextBox.Location = new System.Drawing.Point(372, 25);
            this.sqFtTextBox.Name = "sqFtTextBox";
            this.sqFtTextBox.Size = new System.Drawing.Size(100, 22);
            this.sqFtTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(372, 89);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 2;
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborHoursLabel.Location = new System.Drawing.Point(372, 199);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.laborHoursLabel.TabIndex = 14;
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostLabel.Location = new System.Drawing.Point(372, 257);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(100, 23);
            this.paintCostLabel.TabIndex = 15;
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostLabel.Location = new System.Drawing.Point(372, 311);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(100, 23);
            this.laborCostLabel.TabIndex = 16;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Location = new System.Drawing.Point(372, 360);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostLabel.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(263, 432);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(159, 84);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 624);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.laborHoursLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.sqFtTextBox);
            this.Controls.Add(this.totalCostOutputDescriptionLabel);
            this.Controls.Add(this.laborChargesOutputDescriptionLabel);
            this.Controls.Add(this.paintCostOutputDescriptionLabel);
            this.Controls.Add(this.hoursOutputDescriptionLabel);
            this.Controls.Add(this.gallonsOutputDescriptionLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.paintPricePromptLabel);
            this.Controls.Add(this.squareFtPromptLabel);
            this.Name = "Form1";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label squareFtPromptLabel;
        private System.Windows.Forms.Label paintPricePromptLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label gallonsOutputDescriptionLabel;
        private System.Windows.Forms.Label hoursOutputDescriptionLabel;
        private System.Windows.Forms.Label paintCostOutputDescriptionLabel;
        private System.Windows.Forms.Label laborChargesOutputDescriptionLabel;
        private System.Windows.Forms.Label totalCostOutputDescriptionLabel;
        private System.Windows.Forms.TextBox sqFtTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

