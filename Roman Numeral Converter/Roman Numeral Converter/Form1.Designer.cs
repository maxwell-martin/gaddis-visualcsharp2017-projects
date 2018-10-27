namespace Roman_Numeral_Converter
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.romanNumeralLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(43, 93);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(227, 17);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter a number between 1 and 10:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(156, 159);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(114, 17);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "Roman Numeral:";
            // 
            // romanNumeralLabel
            // 
            this.romanNumeralLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.romanNumeralLabel.Location = new System.Drawing.Point(309, 153);
            this.romanNumeralLabel.Name = "romanNumeralLabel";
            this.romanNumeralLabel.Size = new System.Drawing.Size(100, 23);
            this.romanNumeralLabel.TabIndex = 2;
            this.romanNumeralLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(309, 93);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 3;
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(232, 212);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(88, 40);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 291);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.romanNumeralLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label romanNumeralLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

