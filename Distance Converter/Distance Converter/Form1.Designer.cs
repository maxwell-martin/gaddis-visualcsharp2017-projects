namespace Distance_Converter
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
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(57, 62);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(254, 17);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter the distance you want to convert:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(317, 59);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(202, 22);
            this.distanceTextBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(60, 103);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(220, 193);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(299, 103);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(220, 193);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 16;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(33, 67);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(150, 52);
            this.fromListBox.TabIndex = 2;
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 16;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(38, 67);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(150, 52);
            this.toListBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(132, 362);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(136, 17);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Converted Distance:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceLabel.Location = new System.Drawing.Point(274, 347);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(149, 45);
            this.distanceLabel.TabIndex = 5;
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(149, 428);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 42);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(329, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 42);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 503);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

