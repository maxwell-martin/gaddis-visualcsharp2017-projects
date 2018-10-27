namespace Distance_Traveled
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
            this.speedPromptLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.distanceIn5HoursButton = new System.Windows.Forms.Button();
            this.distanceIn8HoursButton = new System.Windows.Forms.Button();
            this.distanceIn12HoursButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedPromptLabel
            // 
            this.speedPromptLabel.AutoSize = true;
            this.speedPromptLabel.Location = new System.Drawing.Point(151, 95);
            this.speedPromptLabel.Name = "speedPromptLabel";
            this.speedPromptLabel.Size = new System.Drawing.Size(234, 17);
            this.speedPromptLabel.TabIndex = 0;
            this.speedPromptLabel.Text = "Enter a car\'s speed in mph (Ex: 80):";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(408, 92);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(226, 22);
            this.speedTextBox.TabIndex = 1;
            // 
            // distanceIn5HoursButton
            // 
            this.distanceIn5HoursButton.AutoSize = true;
            this.distanceIn5HoursButton.Location = new System.Drawing.Point(304, 159);
            this.distanceIn5HoursButton.Name = "distanceIn5HoursButton";
            this.distanceIn5HoursButton.Size = new System.Drawing.Size(150, 27);
            this.distanceIn5HoursButton.TabIndex = 2;
            this.distanceIn5HoursButton.Text = "Distance in 5 Hours";
            this.distanceIn5HoursButton.UseVisualStyleBackColor = true;
            this.distanceIn5HoursButton.Click += new System.EventHandler(this.distanceIn5HoursButton_Click);
            // 
            // distanceIn8HoursButton
            // 
            this.distanceIn8HoursButton.AutoSize = true;
            this.distanceIn8HoursButton.Location = new System.Drawing.Point(304, 241);
            this.distanceIn8HoursButton.Name = "distanceIn8HoursButton";
            this.distanceIn8HoursButton.Size = new System.Drawing.Size(150, 27);
            this.distanceIn8HoursButton.TabIndex = 3;
            this.distanceIn8HoursButton.Text = "Distance in 8 Hours";
            this.distanceIn8HoursButton.UseVisualStyleBackColor = true;
            this.distanceIn8HoursButton.Click += new System.EventHandler(this.distanceIn8HoursButton_Click);
            // 
            // distanceIn12HoursButton
            // 
            this.distanceIn12HoursButton.AutoSize = true;
            this.distanceIn12HoursButton.Location = new System.Drawing.Point(304, 320);
            this.distanceIn12HoursButton.Name = "distanceIn12HoursButton";
            this.distanceIn12HoursButton.Size = new System.Drawing.Size(150, 27);
            this.distanceIn12HoursButton.TabIndex = 4;
            this.distanceIn12HoursButton.Text = "Distance in 12 Hours";
            this.distanceIn12HoursButton.UseVisualStyleBackColor = true;
            this.distanceIn12HoursButton.Click += new System.EventHandler(this.distanceIn12HoursButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 528);
            this.Controls.Add(this.distanceIn12HoursButton);
            this.Controls.Add(this.distanceIn8HoursButton);
            this.Controls.Add(this.distanceIn5HoursButton);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.speedPromptLabel);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedPromptLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button distanceIn5HoursButton;
        private System.Windows.Forms.Button distanceIn8HoursButton;
        private System.Windows.Forms.Button distanceIn12HoursButton;
    }
}

