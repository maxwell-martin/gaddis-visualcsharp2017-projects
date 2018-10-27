namespace Tuition_Increase
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.tuitionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(26, 36);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(502, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Click calculate to see how much your tuition will increase over the next 5 years." +
    "";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(215, 349);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 43);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // tuitionListBox
            // 
            this.tuitionListBox.FormattingEnabled = true;
            this.tuitionListBox.ItemHeight = 16;
            this.tuitionListBox.Location = new System.Drawing.Point(81, 79);
            this.tuitionListBox.Name = "tuitionListBox";
            this.tuitionListBox.Size = new System.Drawing.Size(375, 244);
            this.tuitionListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 422);
            this.Controls.Add(this.tuitionListBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox tuitionListBox;
    }
}

