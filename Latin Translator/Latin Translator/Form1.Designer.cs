namespace Latin_Translator
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
            this.sinisterButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(104, 242);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(115, 81);
            this.sinisterButton.TabIndex = 0;
            this.sinisterButton.Text = "Sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(495, 242);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(115, 81);
            this.dexterButton.TabIndex = 1;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(297, 242);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(115, 81);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Location = new System.Drawing.Point(169, 56);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(374, 17);
            this.directionsLabel.TabIndex = 3;
            this.directionsLabel.Text = "Click one of the three Latin words to translate it to English.";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.translationLabel.Location = new System.Drawing.Point(215, 125);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(278, 40);
            this.translationLabel.TabIndex = 4;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 382);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.sinisterButton);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.Label translationLabel;
    }
}

