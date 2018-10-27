namespace Factorials_Ch5_12
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
            this.integerTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(124, 49);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(301, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a nonnegative integer in the range 0-12.";
            // 
            // integerTextBox
            // 
            this.integerTextBox.Location = new System.Drawing.Point(222, 87);
            this.integerTextBox.Name = "integerTextBox";
            this.integerTextBox.Size = new System.Drawing.Size(100, 22);
            this.integerTextBox.TabIndex = 1;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(222, 133);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 46);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display Factorial";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 206);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.integerTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox integerTextBox;
        private System.Windows.Forms.Button displayButton;
    }
}

