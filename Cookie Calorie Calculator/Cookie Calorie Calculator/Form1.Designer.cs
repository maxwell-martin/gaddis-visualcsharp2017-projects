namespace Cookie_Calorie_Calculator
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
            this.cookieAmtPromptLabel = new System.Windows.Forms.Label();
            this.cookiesTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookieAmtPromptLabel
            // 
            this.cookieAmtPromptLabel.AutoSize = true;
            this.cookieAmtPromptLabel.Location = new System.Drawing.Point(71, 47);
            this.cookieAmtPromptLabel.Name = "cookieAmtPromptLabel";
            this.cookieAmtPromptLabel.Size = new System.Drawing.Size(207, 17);
            this.cookieAmtPromptLabel.TabIndex = 0;
            this.cookieAmtPromptLabel.Text = "How many cookies did you eat?";
            // 
            // cookiesTextBox
            // 
            this.cookiesTextBox.Location = new System.Drawing.Point(327, 44);
            this.cookiesTextBox.Name = "cookiesTextBox";
            this.cookiesTextBox.Size = new System.Drawing.Size(100, 22);
            this.cookiesTextBox.TabIndex = 1;
            this.cookiesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(146, 145);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(132, 17);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Calories consumed:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Location = new System.Drawing.Point(327, 144);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.caloriesLabel.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(217, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 53);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 461);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cookiesTextBox);
            this.Controls.Add(this.cookieAmtPromptLabel);
            this.Name = "Form1";
            this.Text = "Cookie Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cookieAmtPromptLabel;
        private System.Windows.Forms.TextBox cookiesTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

