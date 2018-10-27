namespace TipTaxTotal
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
            this.mealPricePromptLabel = new System.Windows.Forms.Label();
            this.mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.tipOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.taxOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPricePromptLabel
            // 
            this.mealPricePromptLabel.AutoSize = true;
            this.mealPricePromptLabel.Location = new System.Drawing.Point(291, 85);
            this.mealPricePromptLabel.Name = "mealPricePromptLabel";
            this.mealPricePromptLabel.Size = new System.Drawing.Size(131, 17);
            this.mealPricePromptLabel.TabIndex = 0;
            this.mealPricePromptLabel.Text = "Enter price of meal:";
            // 
            // mealPriceTextBox
            // 
            this.mealPriceTextBox.Location = new System.Drawing.Point(488, 80);
            this.mealPriceTextBox.Name = "mealPriceTextBox";
            this.mealPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.mealPriceTextBox.TabIndex = 1;
            // 
            // tipOutputDescriptionLabel
            // 
            this.tipOutputDescriptionLabel.AutoSize = true;
            this.tipOutputDescriptionLabel.Location = new System.Drawing.Point(291, 157);
            this.tipOutputDescriptionLabel.Name = "tipOutputDescriptionLabel";
            this.tipOutputDescriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.tipOutputDescriptionLabel.TabIndex = 2;
            this.tipOutputDescriptionLabel.Text = "Tip (15%):";
            // 
            // taxOutputDescriptionLabel
            // 
            this.taxOutputDescriptionLabel.AutoSize = true;
            this.taxOutputDescriptionLabel.Location = new System.Drawing.Point(291, 236);
            this.taxOutputDescriptionLabel.Name = "taxOutputDescriptionLabel";
            this.taxOutputDescriptionLabel.Size = new System.Drawing.Size(69, 17);
            this.taxOutputDescriptionLabel.TabIndex = 3;
            this.taxOutputDescriptionLabel.Text = "Tax (7%):";
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(291, 327);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(44, 17);
            this.totalOutputDescriptionLabel.TabIndex = 4;
            this.totalOutputDescriptionLabel.Text = "Total:";
            // 
            // tipLabel
            // 
            this.tipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabel.Location = new System.Drawing.Point(488, 151);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(100, 23);
            this.tipLabel.TabIndex = 5;
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(488, 230);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(488, 321);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(378, 394);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 27);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 506);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.totalOutputDescriptionLabel);
            this.Controls.Add(this.taxOutputDescriptionLabel);
            this.Controls.Add(this.tipOutputDescriptionLabel);
            this.Controls.Add(this.mealPriceTextBox);
            this.Controls.Add(this.mealPricePromptLabel);
            this.Name = "Form1";
            this.Text = "Tip, Tax, and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPricePromptLabel;
        private System.Windows.Forms.TextBox mealPriceTextBox;
        private System.Windows.Forms.Label tipOutputDescriptionLabel;
        private System.Windows.Forms.Label taxOutputDescriptionLabel;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

