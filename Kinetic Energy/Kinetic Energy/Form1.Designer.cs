namespace Kinetic_Energy
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
            this.massPromptLabel = new System.Windows.Forms.Label();
            this.velocityPromptLabel = new System.Windows.Forms.Label();
            this.keOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.keLabel = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massPromptLabel
            // 
            this.massPromptLabel.AutoSize = true;
            this.massPromptLabel.Location = new System.Drawing.Point(105, 63);
            this.massPromptLabel.Name = "massPromptLabel";
            this.massPromptLabel.Size = new System.Drawing.Size(112, 17);
            this.massPromptLabel.TabIndex = 0;
            this.massPromptLabel.Text = "Enter mass (kg):";
            // 
            // velocityPromptLabel
            // 
            this.velocityPromptLabel.AutoSize = true;
            this.velocityPromptLabel.Location = new System.Drawing.Point(84, 121);
            this.velocityPromptLabel.Name = "velocityPromptLabel";
            this.velocityPromptLabel.Size = new System.Drawing.Size(133, 17);
            this.velocityPromptLabel.TabIndex = 1;
            this.velocityPromptLabel.Text = "Enter velocity (m/s):";
            // 
            // keOutputDescriptionLabel
            // 
            this.keOutputDescriptionLabel.AutoSize = true;
            this.keOutputDescriptionLabel.Location = new System.Drawing.Point(93, 194);
            this.keOutputDescriptionLabel.Name = "keOutputDescriptionLabel";
            this.keOutputDescriptionLabel.Size = new System.Drawing.Size(124, 17);
            this.keOutputDescriptionLabel.TabIndex = 2;
            this.keOutputDescriptionLabel.Text = "Kinetic Energy (J):";
            // 
            // keLabel
            // 
            this.keLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keLabel.Location = new System.Drawing.Point(249, 189);
            this.keLabel.Name = "keLabel";
            this.keLabel.Size = new System.Drawing.Size(100, 22);
            this.keLabel.TabIndex = 3;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(249, 58);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 22);
            this.massTextBox.TabIndex = 4;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(249, 116);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(100, 22);
            this.velocityTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(179, 250);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 42);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.keLabel);
            this.Controls.Add(this.keOutputDescriptionLabel);
            this.Controls.Add(this.velocityPromptLabel);
            this.Controls.Add(this.massPromptLabel);
            this.Name = "Form1";
            this.Text = "Kinetic Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massPromptLabel;
        private System.Windows.Forms.Label velocityPromptLabel;
        private System.Windows.Forms.Label keOutputDescriptionLabel;
        private System.Windows.Forms.Label keLabel;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

