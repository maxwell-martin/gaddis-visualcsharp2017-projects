namespace Word_Counter
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
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(62, 64);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(587, 22);
            this.entryTextBox.TabIndex = 0;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(244, 111);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(210, 40);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Number of Words";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(264, 23);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(167, 17);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Type in a string of words.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 172);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.entryTextBox);
            this.Name = "Form1";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

