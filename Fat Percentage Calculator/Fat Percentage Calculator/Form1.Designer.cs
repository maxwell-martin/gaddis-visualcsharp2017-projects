namespace Fat_Percentage_Calculator
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
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.caloriesPromptLabel = new System.Windows.Forms.Label();
            this.fatPromptLabel = new System.Windows.Forms.Label();
            this.fatCaloriesPercentOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.fatCaloriesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.fatCaloriesPercentageLabel = new System.Windows.Forms.Label();
            this.lowFatCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.fatCaloriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(378, 47);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 22);
            this.caloriesTextBox.TabIndex = 0;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(378, 88);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 22);
            this.fatTextBox.TabIndex = 1;
            // 
            // caloriesPromptLabel
            // 
            this.caloriesPromptLabel.AutoSize = true;
            this.caloriesPromptLabel.Location = new System.Drawing.Point(159, 50);
            this.caloriesPromptLabel.Name = "caloriesPromptLabel";
            this.caloriesPromptLabel.Size = new System.Drawing.Size(99, 17);
            this.caloriesPromptLabel.TabIndex = 2;
            this.caloriesPromptLabel.Text = "Total Calories:";
            // 
            // fatPromptLabel
            // 
            this.fatPromptLabel.AutoSize = true;
            this.fatPromptLabel.Location = new System.Drawing.Point(159, 88);
            this.fatPromptLabel.Name = "fatPromptLabel";
            this.fatPromptLabel.Size = new System.Drawing.Size(114, 17);
            this.fatPromptLabel.TabIndex = 3;
            this.fatPromptLabel.Text = "Total Fat Grams:";
            // 
            // fatCaloriesPercentOutputDescriptionLabel
            // 
            this.fatCaloriesPercentOutputDescriptionLabel.AutoSize = true;
            this.fatCaloriesPercentOutputDescriptionLabel.Location = new System.Drawing.Point(159, 321);
            this.fatCaloriesPercentOutputDescriptionLabel.Name = "fatCaloriesPercentOutputDescriptionLabel";
            this.fatCaloriesPercentOutputDescriptionLabel.Size = new System.Drawing.Size(206, 17);
            this.fatCaloriesPercentOutputDescriptionLabel.TabIndex = 4;
            this.fatCaloriesPercentOutputDescriptionLabel.Text = "Percentage of calories from fat:";
            // 
            // fatCaloriesOutputDescriptionLabel
            // 
            this.fatCaloriesOutputDescriptionLabel.AutoSize = true;
            this.fatCaloriesOutputDescriptionLabel.Location = new System.Drawing.Point(159, 273);
            this.fatCaloriesOutputDescriptionLabel.Name = "fatCaloriesOutputDescriptionLabel";
            this.fatCaloriesOutputDescriptionLabel.Size = new System.Drawing.Size(115, 17);
            this.fatCaloriesOutputDescriptionLabel.TabIndex = 5;
            this.fatCaloriesOutputDescriptionLabel.Text = "Calories from fat:";
            // 
            // fatCaloriesPercentageLabel
            // 
            this.fatCaloriesPercentageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatCaloriesPercentageLabel.Location = new System.Drawing.Point(404, 311);
            this.fatCaloriesPercentageLabel.Name = "fatCaloriesPercentageLabel";
            this.fatCaloriesPercentageLabel.Size = new System.Drawing.Size(74, 27);
            this.fatCaloriesPercentageLabel.TabIndex = 6;
            // 
            // lowFatCheckBox
            // 
            this.lowFatCheckBox.AutoSize = true;
            this.lowFatCheckBox.Location = new System.Drawing.Point(188, 141);
            this.lowFatCheckBox.Name = "lowFatCheckBox";
            this.lowFatCheckBox.Size = new System.Drawing.Size(281, 21);
            this.lowFatCheckBox.TabIndex = 8;
            this.lowFatCheckBox.Text = "Click to see if food is considered low fat.";
            this.lowFatCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(278, 195);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 44);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // fatCaloriesLabel
            // 
            this.fatCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatCaloriesLabel.Location = new System.Drawing.Point(404, 263);
            this.fatCaloriesLabel.Name = "fatCaloriesLabel";
            this.fatCaloriesLabel.Size = new System.Drawing.Size(74, 27);
            this.fatCaloriesLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 453);
            this.Controls.Add(this.fatCaloriesLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lowFatCheckBox);
            this.Controls.Add(this.fatCaloriesPercentageLabel);
            this.Controls.Add(this.fatCaloriesOutputDescriptionLabel);
            this.Controls.Add(this.fatCaloriesPercentOutputDescriptionLabel);
            this.Controls.Add(this.fatPromptLabel);
            this.Controls.Add(this.caloriesPromptLabel);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Name = "Form1";
            this.Text = "Fat Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.Label caloriesPromptLabel;
        private System.Windows.Forms.Label fatPromptLabel;
        private System.Windows.Forms.Label fatCaloriesPercentOutputDescriptionLabel;
        private System.Windows.Forms.Label fatCaloriesOutputDescriptionLabel;
        private System.Windows.Forms.Label fatCaloriesPercentageLabel;
        private System.Windows.Forms.CheckBox lowFatCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label fatCaloriesLabel;
    }
}

