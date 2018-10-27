namespace Exam_Scores
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.sect1ListBox = new System.Windows.Forms.ListBox();
            this.sect1GroupBox = new System.Windows.Forms.GroupBox();
            this.sect2GroupBox = new System.Windows.Forms.GroupBox();
            this.sect2ListBox = new System.Windows.Forms.ListBox();
            this.sect3GroupBox = new System.Windows.Forms.GroupBox();
            this.sect3ListBox = new System.Windows.Forms.ListBox();
            this.avgSect1DescriptionLabel = new System.Windows.Forms.Label();
            this.avgSect2DescriptionLabel = new System.Windows.Forms.Label();
            this.avgSect3DescriptionLabel = new System.Windows.Forms.Label();
            this.avgSect1Label = new System.Windows.Forms.Label();
            this.avgSect2Label = new System.Windows.Forms.Label();
            this.avgSect3Label = new System.Windows.Forms.Label();
            this.highestScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.overallAverageDescriptionLabel = new System.Windows.Forms.Label();
            this.overallAvgLabel = new System.Windows.Forms.Label();
            this.highestScoreLabel = new System.Windows.Forms.Label();
            this.highestScoreSectLabel = new System.Windows.Forms.Label();
            this.highestScoreSectDescriptionLabel = new System.Windows.Forms.Label();
            this.lowestScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.lowestScoreLabel = new System.Windows.Forms.Label();
            this.lowestScoreSectDescriptionLabel = new System.Windows.Forms.Label();
            this.lowestScoreSectLabel = new System.Windows.Forms.Label();
            this.sect1GroupBox.SuspendLayout();
            this.sect2GroupBox.SuspendLayout();
            this.sect3GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(265, 36);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 39);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sect1ListBox
            // 
            this.sect1ListBox.FormattingEnabled = true;
            this.sect1ListBox.ItemHeight = 16;
            this.sect1ListBox.Location = new System.Drawing.Point(6, 21);
            this.sect1ListBox.Name = "sect1ListBox";
            this.sect1ListBox.Size = new System.Drawing.Size(118, 196);
            this.sect1ListBox.TabIndex = 1;
            // 
            // sect1GroupBox
            // 
            this.sect1GroupBox.Controls.Add(this.sect1ListBox);
            this.sect1GroupBox.Location = new System.Drawing.Point(51, 107);
            this.sect1GroupBox.Name = "sect1GroupBox";
            this.sect1GroupBox.Size = new System.Drawing.Size(132, 231);
            this.sect1GroupBox.TabIndex = 4;
            this.sect1GroupBox.TabStop = false;
            this.sect1GroupBox.Text = "Section 1";
            // 
            // sect2GroupBox
            // 
            this.sect2GroupBox.Controls.Add(this.sect2ListBox);
            this.sect2GroupBox.Location = new System.Drawing.Point(243, 107);
            this.sect2GroupBox.Name = "sect2GroupBox";
            this.sect2GroupBox.Size = new System.Drawing.Size(132, 231);
            this.sect2GroupBox.TabIndex = 5;
            this.sect2GroupBox.TabStop = false;
            this.sect2GroupBox.Text = "Section 2";
            // 
            // sect2ListBox
            // 
            this.sect2ListBox.FormattingEnabled = true;
            this.sect2ListBox.ItemHeight = 16;
            this.sect2ListBox.Location = new System.Drawing.Point(6, 21);
            this.sect2ListBox.Name = "sect2ListBox";
            this.sect2ListBox.Size = new System.Drawing.Size(118, 196);
            this.sect2ListBox.TabIndex = 1;
            // 
            // sect3GroupBox
            // 
            this.sect3GroupBox.Controls.Add(this.sect3ListBox);
            this.sect3GroupBox.Location = new System.Drawing.Point(451, 107);
            this.sect3GroupBox.Name = "sect3GroupBox";
            this.sect3GroupBox.Size = new System.Drawing.Size(132, 231);
            this.sect3GroupBox.TabIndex = 5;
            this.sect3GroupBox.TabStop = false;
            this.sect3GroupBox.Text = "Section 3";
            // 
            // sect3ListBox
            // 
            this.sect3ListBox.FormattingEnabled = true;
            this.sect3ListBox.ItemHeight = 16;
            this.sect3ListBox.Location = new System.Drawing.Point(6, 21);
            this.sect3ListBox.Name = "sect3ListBox";
            this.sect3ListBox.Size = new System.Drawing.Size(118, 196);
            this.sect3ListBox.TabIndex = 1;
            // 
            // avgSect1DescriptionLabel
            // 
            this.avgSect1DescriptionLabel.AutoSize = true;
            this.avgSect1DescriptionLabel.Location = new System.Drawing.Point(48, 360);
            this.avgSect1DescriptionLabel.Name = "avgSect1DescriptionLabel";
            this.avgSect1DescriptionLabel.Size = new System.Drawing.Size(65, 17);
            this.avgSect1DescriptionLabel.TabIndex = 6;
            this.avgSect1DescriptionLabel.Text = "Average:";
            // 
            // avgSect2DescriptionLabel
            // 
            this.avgSect2DescriptionLabel.AutoSize = true;
            this.avgSect2DescriptionLabel.Location = new System.Drawing.Point(240, 360);
            this.avgSect2DescriptionLabel.Name = "avgSect2DescriptionLabel";
            this.avgSect2DescriptionLabel.Size = new System.Drawing.Size(65, 17);
            this.avgSect2DescriptionLabel.TabIndex = 7;
            this.avgSect2DescriptionLabel.Text = "Average:";
            // 
            // avgSect3DescriptionLabel
            // 
            this.avgSect3DescriptionLabel.AutoSize = true;
            this.avgSect3DescriptionLabel.Location = new System.Drawing.Point(448, 360);
            this.avgSect3DescriptionLabel.Name = "avgSect3DescriptionLabel";
            this.avgSect3DescriptionLabel.Size = new System.Drawing.Size(65, 17);
            this.avgSect3DescriptionLabel.TabIndex = 8;
            this.avgSect3DescriptionLabel.Text = "Average:";
            // 
            // avgSect1Label
            // 
            this.avgSect1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgSect1Label.Location = new System.Drawing.Point(119, 354);
            this.avgSect1Label.Name = "avgSect1Label";
            this.avgSect1Label.Size = new System.Drawing.Size(64, 29);
            this.avgSect1Label.TabIndex = 9;
            this.avgSect1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgSect2Label
            // 
            this.avgSect2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgSect2Label.Location = new System.Drawing.Point(311, 354);
            this.avgSect2Label.Name = "avgSect2Label";
            this.avgSect2Label.Size = new System.Drawing.Size(64, 29);
            this.avgSect2Label.TabIndex = 10;
            this.avgSect2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgSect3Label
            // 
            this.avgSect3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgSect3Label.Location = new System.Drawing.Point(519, 354);
            this.avgSect3Label.Name = "avgSect3Label";
            this.avgSect3Label.Size = new System.Drawing.Size(64, 29);
            this.avgSect3Label.TabIndex = 11;
            this.avgSect3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestScoreDescriptionLabel
            // 
            this.highestScoreDescriptionLabel.AutoSize = true;
            this.highestScoreDescriptionLabel.Location = new System.Drawing.Point(137, 498);
            this.highestScoreDescriptionLabel.Name = "highestScoreDescriptionLabel";
            this.highestScoreDescriptionLabel.Size = new System.Drawing.Size(150, 17);
            this.highestScoreDescriptionLabel.TabIndex = 12;
            this.highestScoreDescriptionLabel.Text = "Highest Score Overall:";
            // 
            // overallAverageDescriptionLabel
            // 
            this.overallAverageDescriptionLabel.AutoSize = true;
            this.overallAverageDescriptionLabel.Location = new System.Drawing.Point(173, 456);
            this.overallAverageDescriptionLabel.Name = "overallAverageDescriptionLabel";
            this.overallAverageDescriptionLabel.Size = new System.Drawing.Size(114, 17);
            this.overallAverageDescriptionLabel.TabIndex = 13;
            this.overallAverageDescriptionLabel.Text = "Overall Average:";
            // 
            // overallAvgLabel
            // 
            this.overallAvgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overallAvgLabel.Location = new System.Drawing.Point(295, 450);
            this.overallAvgLabel.Name = "overallAvgLabel";
            this.overallAvgLabel.Size = new System.Drawing.Size(59, 23);
            this.overallAvgLabel.TabIndex = 14;
            this.overallAvgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestScoreLabel
            // 
            this.highestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestScoreLabel.Location = new System.Drawing.Point(295, 492);
            this.highestScoreLabel.Name = "highestScoreLabel";
            this.highestScoreLabel.Size = new System.Drawing.Size(59, 23);
            this.highestScoreLabel.TabIndex = 15;
            this.highestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestScoreSectLabel
            // 
            this.highestScoreSectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestScoreSectLabel.Location = new System.Drawing.Point(360, 492);
            this.highestScoreSectLabel.Name = "highestScoreSectLabel";
            this.highestScoreSectLabel.Size = new System.Drawing.Size(112, 23);
            this.highestScoreSectLabel.TabIndex = 16;
            this.highestScoreSectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestScoreSectDescriptionLabel
            // 
            this.highestScoreSectDescriptionLabel.AutoSize = true;
            this.highestScoreSectDescriptionLabel.Location = new System.Drawing.Point(388, 475);
            this.highestScoreSectDescriptionLabel.Name = "highestScoreSectDescriptionLabel";
            this.highestScoreSectDescriptionLabel.Size = new System.Drawing.Size(55, 17);
            this.highestScoreSectDescriptionLabel.TabIndex = 17;
            this.highestScoreSectDescriptionLabel.Text = "Section";
            // 
            // lowestScoreDescriptionLabel
            // 
            this.lowestScoreDescriptionLabel.AutoSize = true;
            this.lowestScoreDescriptionLabel.Location = new System.Drawing.Point(141, 544);
            this.lowestScoreDescriptionLabel.Name = "lowestScoreDescriptionLabel";
            this.lowestScoreDescriptionLabel.Size = new System.Drawing.Size(146, 17);
            this.lowestScoreDescriptionLabel.TabIndex = 18;
            this.lowestScoreDescriptionLabel.Text = "Lowest Score Overall:";
            // 
            // lowestScoreLabel
            // 
            this.lowestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestScoreLabel.Location = new System.Drawing.Point(295, 538);
            this.lowestScoreLabel.Name = "lowestScoreLabel";
            this.lowestScoreLabel.Size = new System.Drawing.Size(59, 23);
            this.lowestScoreLabel.TabIndex = 19;
            this.lowestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestScoreSectDescriptionLabel
            // 
            this.lowestScoreSectDescriptionLabel.AutoSize = true;
            this.lowestScoreSectDescriptionLabel.Location = new System.Drawing.Point(388, 521);
            this.lowestScoreSectDescriptionLabel.Name = "lowestScoreSectDescriptionLabel";
            this.lowestScoreSectDescriptionLabel.Size = new System.Drawing.Size(55, 17);
            this.lowestScoreSectDescriptionLabel.TabIndex = 21;
            this.lowestScoreSectDescriptionLabel.Text = "Section";
            // 
            // lowestScoreSectLabel
            // 
            this.lowestScoreSectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestScoreSectLabel.Location = new System.Drawing.Point(360, 538);
            this.lowestScoreSectLabel.Name = "lowestScoreSectLabel";
            this.lowestScoreSectLabel.Size = new System.Drawing.Size(112, 23);
            this.lowestScoreSectLabel.TabIndex = 20;
            this.lowestScoreSectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 613);
            this.Controls.Add(this.lowestScoreSectDescriptionLabel);
            this.Controls.Add(this.lowestScoreSectLabel);
            this.Controls.Add(this.lowestScoreLabel);
            this.Controls.Add(this.lowestScoreDescriptionLabel);
            this.Controls.Add(this.highestScoreSectDescriptionLabel);
            this.Controls.Add(this.highestScoreSectLabel);
            this.Controls.Add(this.highestScoreLabel);
            this.Controls.Add(this.overallAvgLabel);
            this.Controls.Add(this.overallAverageDescriptionLabel);
            this.Controls.Add(this.highestScoreDescriptionLabel);
            this.Controls.Add(this.avgSect3Label);
            this.Controls.Add(this.avgSect2Label);
            this.Controls.Add(this.avgSect1Label);
            this.Controls.Add(this.avgSect3DescriptionLabel);
            this.Controls.Add(this.avgSect2DescriptionLabel);
            this.Controls.Add(this.avgSect1DescriptionLabel);
            this.Controls.Add(this.sect3GroupBox);
            this.Controls.Add(this.sect2GroupBox);
            this.Controls.Add(this.sect1GroupBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Exam Scores";
            this.sect1GroupBox.ResumeLayout(false);
            this.sect2GroupBox.ResumeLayout(false);
            this.sect3GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox sect1ListBox;
        private System.Windows.Forms.GroupBox sect1GroupBox;
        private System.Windows.Forms.GroupBox sect2GroupBox;
        private System.Windows.Forms.ListBox sect2ListBox;
        private System.Windows.Forms.GroupBox sect3GroupBox;
        private System.Windows.Forms.ListBox sect3ListBox;
        private System.Windows.Forms.Label avgSect1DescriptionLabel;
        private System.Windows.Forms.Label avgSect2DescriptionLabel;
        private System.Windows.Forms.Label avgSect3DescriptionLabel;
        private System.Windows.Forms.Label avgSect1Label;
        private System.Windows.Forms.Label avgSect2Label;
        private System.Windows.Forms.Label avgSect3Label;
        private System.Windows.Forms.Label highestScoreDescriptionLabel;
        private System.Windows.Forms.Label overallAverageDescriptionLabel;
        private System.Windows.Forms.Label overallAvgLabel;
        private System.Windows.Forms.Label highestScoreLabel;
        private System.Windows.Forms.Label highestScoreSectLabel;
        private System.Windows.Forms.Label highestScoreSectDescriptionLabel;
        private System.Windows.Forms.Label lowestScoreDescriptionLabel;
        private System.Windows.Forms.Label lowestScoreLabel;
        private System.Windows.Forms.Label lowestScoreSectDescriptionLabel;
        private System.Windows.Forms.Label lowestScoreSectLabel;
    }
}

