namespace Vowels_and_Consonants
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
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.vowelsOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.consonantsOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.vowelsLabel = new System.Windows.Forms.Label();
            this.consonantsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(64, 79);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(696, 22);
            this.sentenceTextBox.TabIndex = 0;
            this.sentenceTextBox.TextChanged += new System.EventHandler(this.sentenceTextBox_TextChanged);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(342, 35);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(120, 17);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Enter a sentence.";
            // 
            // vowelsOutputDescriptionLabel
            // 
            this.vowelsOutputDescriptionLabel.AutoSize = true;
            this.vowelsOutputDescriptionLabel.Location = new System.Drawing.Point(282, 140);
            this.vowelsOutputDescriptionLabel.Name = "vowelsOutputDescriptionLabel";
            this.vowelsOutputDescriptionLabel.Size = new System.Drawing.Size(126, 17);
            this.vowelsOutputDescriptionLabel.TabIndex = 3;
            this.vowelsOutputDescriptionLabel.Text = "Number of Vowels:";
            // 
            // consonantsOutputDescriptionLabel
            // 
            this.consonantsOutputDescriptionLabel.AutoSize = true;
            this.consonantsOutputDescriptionLabel.Location = new System.Drawing.Point(251, 184);
            this.consonantsOutputDescriptionLabel.Name = "consonantsOutputDescriptionLabel";
            this.consonantsOutputDescriptionLabel.Size = new System.Drawing.Size(157, 17);
            this.consonantsOutputDescriptionLabel.TabIndex = 4;
            this.consonantsOutputDescriptionLabel.Text = "Number of Consonants:";
            // 
            // vowelsLabel
            // 
            this.vowelsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vowelsLabel.Location = new System.Drawing.Point(414, 134);
            this.vowelsLabel.Name = "vowelsLabel";
            this.vowelsLabel.Size = new System.Drawing.Size(100, 23);
            this.vowelsLabel.TabIndex = 5;
            this.vowelsLabel.Text = "0";
            this.vowelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consonantsLabel
            // 
            this.consonantsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consonantsLabel.Location = new System.Drawing.Point(414, 178);
            this.consonantsLabel.Name = "consonantsLabel";
            this.consonantsLabel.Size = new System.Drawing.Size(100, 23);
            this.consonantsLabel.TabIndex = 6;
            this.consonantsLabel.Text = "0";
            this.consonantsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 244);
            this.Controls.Add(this.consonantsLabel);
            this.Controls.Add(this.vowelsLabel);
            this.Controls.Add(this.consonantsOutputDescriptionLabel);
            this.Controls.Add(this.vowelsOutputDescriptionLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.sentenceTextBox);
            this.Name = "Form1";
            this.Text = "Vowels and Consonants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label vowelsOutputDescriptionLabel;
        private System.Windows.Forms.Label consonantsOutputDescriptionLabel;
        private System.Windows.Forms.Label vowelsLabel;
        private System.Windows.Forms.Label consonantsLabel;
    }
}

