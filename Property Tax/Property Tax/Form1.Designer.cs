namespace Property_Tax
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
            this.propertyValuePromptLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.propertyValueTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyValuePromptLabel
            // 
            this.propertyValuePromptLabel.AutoSize = true;
            this.propertyValuePromptLabel.Location = new System.Drawing.Point(53, 98);
            this.propertyValuePromptLabel.Name = "propertyValuePromptLabel";
            this.propertyValuePromptLabel.Size = new System.Drawing.Size(246, 17);
            this.propertyValuePromptLabel.TabIndex = 0;
            this.propertyValuePromptLabel.Text = "Enter how much the property is worth:";
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(320, 197);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 1;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(253, 200);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(35, 17);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Tax:";
            // 
            // propertyValueTextBox
            // 
            this.propertyValueTextBox.Location = new System.Drawing.Point(320, 98);
            this.propertyValueTextBox.Name = "propertyValueTextBox";
            this.propertyValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.propertyValueTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(204, 291);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(95, 199);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 522);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.propertyValueTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.propertyValuePromptLabel);
            this.Name = "Form1";
            this.Text = "Property Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label propertyValuePromptLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox propertyValueTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

