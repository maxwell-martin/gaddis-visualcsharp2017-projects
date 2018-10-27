namespace Sales_Tax_and_Total
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
            this.amountOfPurchasePromptLabel = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel1 = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel2 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel3 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel4 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.totalSalesTaxLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountOfPurchasePromptLabel
            // 
            this.amountOfPurchasePromptLabel.AutoSize = true;
            this.amountOfPurchasePromptLabel.Location = new System.Drawing.Point(336, 52);
            this.amountOfPurchasePromptLabel.Name = "amountOfPurchasePromptLabel";
            this.amountOfPurchasePromptLabel.Size = new System.Drawing.Size(158, 17);
            this.amountOfPurchasePromptLabel.TabIndex = 0;
            this.amountOfPurchasePromptLabel.Text = "Enter in amount of item:";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(517, 47);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemPriceTextBox.TabIndex = 1;
            // 
            // outputDescriptionLabel1
            // 
            this.outputDescriptionLabel1.AutoSize = true;
            this.outputDescriptionLabel1.Location = new System.Drawing.Point(336, 132);
            this.outputDescriptionLabel1.Name = "outputDescriptionLabel1";
            this.outputDescriptionLabel1.Size = new System.Drawing.Size(106, 17);
            this.outputDescriptionLabel1.TabIndex = 2;
            this.outputDescriptionLabel1.Text = "Amount of item:";
            // 
            // itemLabel
            // 
            this.itemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemLabel.Location = new System.Drawing.Point(517, 126);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(100, 23);
            this.itemLabel.TabIndex = 3;
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputDescriptionLabel2
            // 
            this.outputDescriptionLabel2.AutoSize = true;
            this.outputDescriptionLabel2.Location = new System.Drawing.Point(336, 209);
            this.outputDescriptionLabel2.Name = "outputDescriptionLabel2";
            this.outputDescriptionLabel2.Size = new System.Drawing.Size(138, 17);
            this.outputDescriptionLabel2.TabIndex = 4;
            this.outputDescriptionLabel2.Text = "State sales tax (4%):";
            // 
            // outputDescriptionLabel3
            // 
            this.outputDescriptionLabel3.AutoSize = true;
            this.outputDescriptionLabel3.Location = new System.Drawing.Point(336, 296);
            this.outputDescriptionLabel3.Name = "outputDescriptionLabel3";
            this.outputDescriptionLabel3.Size = new System.Drawing.Size(149, 17);
            this.outputDescriptionLabel3.TabIndex = 6;
            this.outputDescriptionLabel3.Text = "County sales tax (2%):";
            // 
            // outputDescriptionLabel4
            // 
            this.outputDescriptionLabel4.AutoSize = true;
            this.outputDescriptionLabel4.Location = new System.Drawing.Point(336, 380);
            this.outputDescriptionLabel4.Name = "outputDescriptionLabel4";
            this.outputDescriptionLabel4.Size = new System.Drawing.Size(103, 17);
            this.outputDescriptionLabel4.TabIndex = 8;
            this.outputDescriptionLabel4.Text = "Total sales tax:";
            // 
            // outputDescriptionLabel5
            // 
            this.outputDescriptionLabel5.AutoSize = true;
            this.outputDescriptionLabel5.Location = new System.Drawing.Point(336, 455);
            this.outputDescriptionLabel5.Name = "outputDescriptionLabel5";
            this.outputDescriptionLabel5.Size = new System.Drawing.Size(74, 17);
            this.outputDescriptionLabel5.TabIndex = 10;
            this.outputDescriptionLabel5.Text = "Total cost:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(416, 513);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(517, 203);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.stateSalesTaxLabel.TabIndex = 13;
            this.stateSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(517, 290);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.countySalesTaxLabel.TabIndex = 14;
            this.countySalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSalesTaxLabel
            // 
            this.totalSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesTaxLabel.Location = new System.Drawing.Point(517, 374);
            this.totalSalesTaxLabel.Name = "totalSalesTaxLabel";
            this.totalSalesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSalesTaxLabel.TabIndex = 15;
            this.totalSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Location = new System.Drawing.Point(517, 449);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostLabel.TabIndex = 16;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 560);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalSalesTaxLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputDescriptionLabel5);
            this.Controls.Add(this.outputDescriptionLabel4);
            this.Controls.Add(this.outputDescriptionLabel3);
            this.Controls.Add(this.outputDescriptionLabel2);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.outputDescriptionLabel1);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.amountOfPurchasePromptLabel);
            this.Name = "Form1";
            this.Text = "Sales Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountOfPurchasePromptLabel;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel1;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label outputDescriptionLabel2;
        private System.Windows.Forms.Label outputDescriptionLabel3;
        private System.Windows.Forms.Label outputDescriptionLabel4;
        private System.Windows.Forms.Label outputDescriptionLabel5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label totalSalesTaxLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

