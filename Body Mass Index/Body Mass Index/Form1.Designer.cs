namespace Body_Mass_Index
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
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.instructionLabel2 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(417, 85);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 0;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(417, 149);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 1;
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Location = new System.Drawing.Point(227, 90);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(166, 17);
            this.instructionLabel1.TabIndex = 2;
            this.instructionLabel1.Text = "Enter weight (in pounds):";
            // 
            // instructionLabel2
            // 
            this.instructionLabel2.AutoSize = true;
            this.instructionLabel2.Location = new System.Drawing.Point(227, 154);
            this.instructionLabel2.Name = "instructionLabel2";
            this.instructionLabel2.Size = new System.Drawing.Size(159, 17);
            this.instructionLabel2.TabIndex = 3;
            this.instructionLabel2.Text = "Enter height (in inches):";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(227, 250);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(35, 17);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "BMI:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmiLabel.Location = new System.Drawing.Point(417, 244);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(100, 23);
            this.bmiLabel.TabIndex = 5;
            this.bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(305, 317);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 27);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 585);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.instructionLabel2);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Name = "Form1";
            this.Text = "Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label instructionLabel2;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

