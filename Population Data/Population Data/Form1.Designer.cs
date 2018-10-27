namespace Population_Data
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
            this.readButton = new System.Windows.Forms.Button();
            this.avgAnnualChangeDescriptionLabel = new System.Windows.Forms.Label();
            this.avgAnnualChangeLabel = new System.Windows.Forms.Label();
            this.greatestIncreaseLabel = new System.Windows.Forms.Label();
            this.leastIncreaseLabel = new System.Windows.Forms.Label();
            this.greatestIncreaseDescriptionLabel = new System.Windows.Forms.Label();
            this.leastIncreaseDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(309, 67);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(87, 38);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // avgAnnualChangeDescriptionLabel
            // 
            this.avgAnnualChangeDescriptionLabel.AutoSize = true;
            this.avgAnnualChangeDescriptionLabel.Location = new System.Drawing.Point(69, 170);
            this.avgAnnualChangeDescriptionLabel.Name = "avgAnnualChangeDescriptionLabel";
            this.avgAnnualChangeDescriptionLabel.Size = new System.Drawing.Size(327, 17);
            this.avgAnnualChangeDescriptionLabel.TabIndex = 1;
            this.avgAnnualChangeDescriptionLabel.Text = "Average Annual Population Change for 1950-1990";
            // 
            // avgAnnualChangeLabel
            // 
            this.avgAnnualChangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgAnnualChangeLabel.Location = new System.Drawing.Point(432, 164);
            this.avgAnnualChangeLabel.Name = "avgAnnualChangeLabel";
            this.avgAnnualChangeLabel.Size = new System.Drawing.Size(100, 23);
            this.avgAnnualChangeLabel.TabIndex = 2;
            this.avgAnnualChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greatestIncreaseLabel
            // 
            this.greatestIncreaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greatestIncreaseLabel.Location = new System.Drawing.Point(432, 237);
            this.greatestIncreaseLabel.Name = "greatestIncreaseLabel";
            this.greatestIncreaseLabel.Size = new System.Drawing.Size(100, 23);
            this.greatestIncreaseLabel.TabIndex = 3;
            this.greatestIncreaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leastIncreaseLabel
            // 
            this.leastIncreaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leastIncreaseLabel.Location = new System.Drawing.Point(432, 315);
            this.leastIncreaseLabel.Name = "leastIncreaseLabel";
            this.leastIncreaseLabel.Size = new System.Drawing.Size(100, 23);
            this.leastIncreaseLabel.TabIndex = 4;
            this.leastIncreaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greatestIncreaseDescriptionLabel
            // 
            this.greatestIncreaseDescriptionLabel.AutoSize = true;
            this.greatestIncreaseDescriptionLabel.Location = new System.Drawing.Point(127, 240);
            this.greatestIncreaseDescriptionLabel.Name = "greatestIncreaseDescriptionLabel";
            this.greatestIncreaseDescriptionLabel.Size = new System.Drawing.Size(269, 17);
            this.greatestIncreaseDescriptionLabel.TabIndex = 5;
            this.greatestIncreaseDescriptionLabel.Text = "Year with Greatest Increase in Population";
            // 
            // leastIncreaseDescriptionLabel
            // 
            this.leastIncreaseDescriptionLabel.AutoSize = true;
            this.leastIncreaseDescriptionLabel.Location = new System.Drawing.Point(147, 321);
            this.leastIncreaseDescriptionLabel.Name = "leastIncreaseDescriptionLabel";
            this.leastIncreaseDescriptionLabel.Size = new System.Drawing.Size(249, 17);
            this.leastIncreaseDescriptionLabel.TabIndex = 6;
            this.leastIncreaseDescriptionLabel.Text = "Year with Least Increase in Population";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.leastIncreaseDescriptionLabel);
            this.Controls.Add(this.greatestIncreaseDescriptionLabel);
            this.Controls.Add(this.leastIncreaseLabel);
            this.Controls.Add(this.greatestIncreaseLabel);
            this.Controls.Add(this.avgAnnualChangeLabel);
            this.Controls.Add(this.avgAnnualChangeDescriptionLabel);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Population Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label avgAnnualChangeDescriptionLabel;
        private System.Windows.Forms.Label avgAnnualChangeLabel;
        private System.Windows.Forms.Label greatestIncreaseLabel;
        private System.Windows.Forms.Label leastIncreaseLabel;
        private System.Windows.Forms.Label greatestIncreaseDescriptionLabel;
        private System.Windows.Forms.Label leastIncreaseDescriptionLabel;
    }
}

