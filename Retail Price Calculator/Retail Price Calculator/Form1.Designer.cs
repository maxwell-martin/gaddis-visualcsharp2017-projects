namespace Retail_Price_Calculator
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
            this.wholesaleCostTextBox = new System.Windows.Forms.TextBox();
            this.markupTextBox = new System.Windows.Forms.TextBox();
            this.wholesaleCostLabel = new System.Windows.Forms.Label();
            this.markupPercentageLabel = new System.Windows.Forms.Label();
            this.retailPriceOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.retailPriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wholesaleCostTextBox
            // 
            this.wholesaleCostTextBox.Location = new System.Drawing.Point(192, 33);
            this.wholesaleCostTextBox.Name = "wholesaleCostTextBox";
            this.wholesaleCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.wholesaleCostTextBox.TabIndex = 0;
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(192, 81);
            this.markupTextBox.Name = "markupTextBox";
            this.markupTextBox.Size = new System.Drawing.Size(100, 22);
            this.markupTextBox.TabIndex = 1;
            // 
            // wholesaleCostLabel
            // 
            this.wholesaleCostLabel.AutoSize = true;
            this.wholesaleCostLabel.Location = new System.Drawing.Point(67, 36);
            this.wholesaleCostLabel.Name = "wholesaleCostLabel";
            this.wholesaleCostLabel.Size = new System.Drawing.Size(110, 17);
            this.wholesaleCostLabel.TabIndex = 2;
            this.wholesaleCostLabel.Text = "Wholesale Cost:";
            // 
            // markupPercentageLabel
            // 
            this.markupPercentageLabel.AutoSize = true;
            this.markupPercentageLabel.Location = new System.Drawing.Point(41, 86);
            this.markupPercentageLabel.Name = "markupPercentageLabel";
            this.markupPercentageLabel.Size = new System.Drawing.Size(136, 17);
            this.markupPercentageLabel.TabIndex = 3;
            this.markupPercentageLabel.Text = "Markup Percentage:";
            // 
            // retailPriceOutputDescriptionLabel
            // 
            this.retailPriceOutputDescriptionLabel.AutoSize = true;
            this.retailPriceOutputDescriptionLabel.Location = new System.Drawing.Point(93, 146);
            this.retailPriceOutputDescriptionLabel.Name = "retailPriceOutputDescriptionLabel";
            this.retailPriceOutputDescriptionLabel.Size = new System.Drawing.Size(84, 17);
            this.retailPriceOutputDescriptionLabel.TabIndex = 4;
            this.retailPriceOutputDescriptionLabel.Text = "Retail Price:";
            // 
            // retailPriceLabel
            // 
            this.retailPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retailPriceLabel.Location = new System.Drawing.Point(192, 141);
            this.retailPriceLabel.Name = "retailPriceLabel";
            this.retailPriceLabel.Size = new System.Drawing.Size(100, 22);
            this.retailPriceLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(120, 188);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 49);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 260);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.retailPriceLabel);
            this.Controls.Add(this.retailPriceOutputDescriptionLabel);
            this.Controls.Add(this.markupPercentageLabel);
            this.Controls.Add(this.wholesaleCostLabel);
            this.Controls.Add(this.markupTextBox);
            this.Controls.Add(this.wholesaleCostTextBox);
            this.Name = "Form1";
            this.Text = "Retail Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wholesaleCostTextBox;
        private System.Windows.Forms.TextBox markupTextBox;
        private System.Windows.Forms.Label wholesaleCostLabel;
        private System.Windows.Forms.Label markupPercentageLabel;
        private System.Windows.Forms.Label retailPriceOutputDescriptionLabel;
        private System.Windows.Forms.Label retailPriceLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

