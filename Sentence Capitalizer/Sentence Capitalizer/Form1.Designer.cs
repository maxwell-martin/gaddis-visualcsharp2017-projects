namespace Sentence_Capitalizer
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
            this.capitalizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(306, 51);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(120, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a sentence.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(127, 116);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(496, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // capitalizeButton
            // 
            this.capitalizeButton.Location = new System.Drawing.Point(309, 182);
            this.capitalizeButton.Name = "capitalizeButton";
            this.capitalizeButton.Size = new System.Drawing.Size(106, 62);
            this.capitalizeButton.TabIndex = 2;
            this.capitalizeButton.Text = "Capitalize";
            this.capitalizeButton.UseVisualStyleBackColor = true;
            this.capitalizeButton.Click += new System.EventHandler(this.capitalizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 303);
            this.Controls.Add(this.capitalizeButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Sentence Capitalizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button capitalizeButton;
    }
}

