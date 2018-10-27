namespace Most_Frequent_Character
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.mfcLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(320, 45);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(97, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a string.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(105, 96);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(535, 22);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(205, 166);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(169, 17);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Most Frequent Character:";
            // 
            // mfcLabel
            // 
            this.mfcLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mfcLabel.Location = new System.Drawing.Point(380, 160);
            this.mfcLabel.Name = "mfcLabel";
            this.mfcLabel.Size = new System.Drawing.Size(100, 23);
            this.mfcLabel.TabIndex = 3;
            this.mfcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 249);
            this.Controls.Add(this.mfcLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Most Frequent Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label mfcLabel;
    }
}

