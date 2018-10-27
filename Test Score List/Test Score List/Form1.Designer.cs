namespace Test_Score_List
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 16;
            this.testScoresListBox.Location = new System.Drawing.Point(16, 15);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(159, 116);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(317, 21);
            this.avgScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(106, 17);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "Average Score:";
            // 
            // aboveAvgDescriptionLabel
            // 
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(196, 63);
            this.aboveAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(227, 17);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "Number of Scores Above Average:";
            // 
            // belowAvgDescriptionLabel
            // 
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(199, 105);
            this.belowAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(224, 17);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "Number of Scores Below Average:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(433, 15);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(133, 28);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Location = new System.Drawing.Point(433, 57);
            this.aboveAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(133, 28);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Location = new System.Drawing.Point(433, 98);
            this.belowAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(133, 28);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(188, 166);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(100, 28);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(296, 166);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

