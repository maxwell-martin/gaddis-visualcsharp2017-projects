namespace Addition_Tutor
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.gradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(101, 52);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(384, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter in an answer and click grade to see if you are correct.";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(177, 108);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(125, 22);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(308, 108);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 22);
            this.answerTextBox.TabIndex = 2;
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(222, 173);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(105, 44);
            this.gradeButton.TabIndex = 3;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 278);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Addition Tutor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button gradeButton;
    }
}

