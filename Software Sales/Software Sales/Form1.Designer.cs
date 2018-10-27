namespace Software_Sales
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.discountDescriptionLabel = new System.Windows.Forms.Label();
            this.totalDescriptionLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.packagesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(127, 46);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(274, 17);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter the number of packages purchased:";
            // 
            // discountDescriptionLabel
            // 
            this.discountDescriptionLabel.AutoSize = true;
            this.discountDescriptionLabel.Location = new System.Drawing.Point(150, 141);
            this.discountDescriptionLabel.Name = "discountDescriptionLabel";
            this.discountDescriptionLabel.Size = new System.Drawing.Size(67, 17);
            this.discountDescriptionLabel.TabIndex = 1;
            this.discountDescriptionLabel.Text = "Discount:";
            // 
            // totalDescriptionLabel
            // 
            this.totalDescriptionLabel.AutoSize = true;
            this.totalDescriptionLabel.Location = new System.Drawing.Point(150, 226);
            this.totalDescriptionLabel.Name = "totalDescriptionLabel";
            this.totalDescriptionLabel.Size = new System.Drawing.Size(44, 17);
            this.totalDescriptionLabel.TabIndex = 2;
            this.totalDescriptionLabel.Text = "Total:";
            // 
            // discountLabel
            // 
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLabel.Location = new System.Drawing.Point(282, 130);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(92, 28);
            this.discountLabel.TabIndex = 3;
            // 
            // packagesTextBox
            // 
            this.packagesTextBox.Location = new System.Drawing.Point(208, 85);
            this.packagesTextBox.Name = "packagesTextBox";
            this.packagesTextBox.Size = new System.Drawing.Size(100, 22);
            this.packagesTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(208, 285);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 42);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(282, 215);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(92, 28);
            this.totalLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 447);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.packagesTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.totalDescriptionLabel);
            this.Controls.Add(this.discountDescriptionLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label discountDescriptionLabel;
        private System.Windows.Forms.Label totalDescriptionLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox packagesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
    }
}

