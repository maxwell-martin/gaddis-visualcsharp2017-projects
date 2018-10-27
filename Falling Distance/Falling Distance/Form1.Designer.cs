namespace Falling_Distance
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
            this.timePromptLabel = new System.Windows.Forms.Label();
            this.distanceOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timePromptLabel
            // 
            this.timePromptLabel.AutoSize = true;
            this.timePromptLabel.Location = new System.Drawing.Point(65, 77);
            this.timePromptLabel.Name = "timePromptLabel";
            this.timePromptLabel.Size = new System.Drawing.Size(143, 17);
            this.timePromptLabel.TabIndex = 0;
            this.timePromptLabel.Text = "Enter time (seconds):";
            // 
            // distanceOutputDescriptionLabel
            // 
            this.distanceOutputDescriptionLabel.AutoSize = true;
            this.distanceOutputDescriptionLabel.Location = new System.Drawing.Point(84, 136);
            this.distanceOutputDescriptionLabel.Name = "distanceOutputDescriptionLabel";
            this.distanceOutputDescriptionLabel.Size = new System.Drawing.Size(124, 17);
            this.distanceOutputDescriptionLabel.TabIndex = 1;
            this.distanceOutputDescriptionLabel.Text = "Distance (meters):";
            // 
            // distanceLabel
            // 
            this.distanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceLabel.Location = new System.Drawing.Point(231, 131);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(100, 22);
            this.distanceLabel.TabIndex = 2;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(231, 72);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(135, 207);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 56);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 368);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.distanceOutputDescriptionLabel);
            this.Controls.Add(this.timePromptLabel);
            this.Name = "Form1";
            this.Text = "Falling Distance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timePromptLabel;
        private System.Windows.Forms.Label distanceOutputDescriptionLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

