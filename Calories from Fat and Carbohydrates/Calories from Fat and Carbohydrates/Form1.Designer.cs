namespace Calories_from_Fat_and_Carbohydrates
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
            this.fatGramsPromptLabel = new System.Windows.Forms.Label();
            this.carbPromptLabel = new System.Windows.Forms.Label();
            this.fatCaloriesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.carbOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbTextBox = new System.Windows.Forms.TextBox();
            this.carbLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatGramsPromptLabel
            // 
            this.fatGramsPromptLabel.AutoSize = true;
            this.fatGramsPromptLabel.Location = new System.Drawing.Point(87, 43);
            this.fatGramsPromptLabel.Name = "fatGramsPromptLabel";
            this.fatGramsPromptLabel.Size = new System.Drawing.Size(177, 17);
            this.fatGramsPromptLabel.TabIndex = 0;
            this.fatGramsPromptLabel.Text = "Enter number of fat grams:";
            // 
            // carbPromptLabel
            // 
            this.carbPromptLabel.AutoSize = true;
            this.carbPromptLabel.Location = new System.Drawing.Point(75, 83);
            this.carbPromptLabel.Name = "carbPromptLabel";
            this.carbPromptLabel.Size = new System.Drawing.Size(189, 17);
            this.carbPromptLabel.TabIndex = 1;
            this.carbPromptLabel.Text = "Enter number of carb grams:";
            // 
            // fatCaloriesOutputDescriptionLabel
            // 
            this.fatCaloriesOutputDescriptionLabel.AutoSize = true;
            this.fatCaloriesOutputDescriptionLabel.Location = new System.Drawing.Point(109, 135);
            this.fatCaloriesOutputDescriptionLabel.Name = "fatCaloriesOutputDescriptionLabel";
            this.fatCaloriesOutputDescriptionLabel.Size = new System.Drawing.Size(155, 17);
            this.fatCaloriesOutputDescriptionLabel.TabIndex = 2;
            this.fatCaloriesOutputDescriptionLabel.Text = "Total Calories from Fat:";
            // 
            // carbOutputDescriptionLabel
            // 
            this.carbOutputDescriptionLabel.AutoSize = true;
            this.carbOutputDescriptionLabel.Location = new System.Drawing.Point(92, 180);
            this.carbOutputDescriptionLabel.Name = "carbOutputDescriptionLabel";
            this.carbOutputDescriptionLabel.Size = new System.Drawing.Size(172, 17);
            this.carbOutputDescriptionLabel.TabIndex = 3;
            this.carbOutputDescriptionLabel.Text = "Total Calories from Carbs:";
            // 
            // fatLabel
            // 
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatLabel.Location = new System.Drawing.Point(287, 130);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(100, 22);
            this.fatLabel.TabIndex = 4;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(287, 40);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 22);
            this.fatTextBox.TabIndex = 6;
            // 
            // carbTextBox
            // 
            this.carbTextBox.Location = new System.Drawing.Point(287, 83);
            this.carbTextBox.Name = "carbTextBox";
            this.carbTextBox.Size = new System.Drawing.Size(100, 22);
            this.carbTextBox.TabIndex = 7;
            // 
            // carbLabel
            // 
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbLabel.Location = new System.Drawing.Point(287, 175);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(100, 22);
            this.carbLabel.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(182, 235);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 48);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 324);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.carbTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbOutputDescriptionLabel);
            this.Controls.Add(this.fatCaloriesOutputDescriptionLabel);
            this.Controls.Add(this.carbPromptLabel);
            this.Controls.Add(this.fatGramsPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramsPromptLabel;
        private System.Windows.Forms.Label carbPromptLabel;
        private System.Windows.Forms.Label fatCaloriesOutputDescriptionLabel;
        private System.Windows.Forms.Label carbOutputDescriptionLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox carbTextBox;
        private System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

