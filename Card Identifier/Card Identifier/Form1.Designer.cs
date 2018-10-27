namespace Card_Identifier
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
            this.directionsLabel = new System.Windows.Forms.Label();
            this.cardFiveButton = new System.Windows.Forms.PictureBox();
            this.cardFourButton = new System.Windows.Forms.PictureBox();
            this.cardThreeButton = new System.Windows.Forms.PictureBox();
            this.cardTwoButton = new System.Windows.Forms.PictureBox();
            this.cardOneButton = new System.Windows.Forms.PictureBox();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFiveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOneButton)).BeginInit();
            this.SuspendLayout();
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsLabel.Location = new System.Drawing.Point(364, 33);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(195, 18);
            this.directionsLabel.TabIndex = 0;
            this.directionsLabel.Text = "Click a card to see its name.";
            // 
            // cardFiveButton
            // 
            this.cardFiveButton.Image = global::Card_Identifier.Properties.Resources._10_Hearts;
            this.cardFiveButton.Location = new System.Drawing.Point(744, 73);
            this.cardFiveButton.Name = "cardFiveButton";
            this.cardFiveButton.Size = new System.Drawing.Size(168, 150);
            this.cardFiveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFiveButton.TabIndex = 5;
            this.cardFiveButton.TabStop = false;
            this.cardFiveButton.Click += new System.EventHandler(this.cardFiveButton_Click);
            // 
            // cardFourButton
            // 
            this.cardFourButton.Image = global::Card_Identifier.Properties.Resources.Ace_Diamonds;
            this.cardFourButton.Location = new System.Drawing.Point(546, 73);
            this.cardFourButton.Name = "cardFourButton";
            this.cardFourButton.Size = new System.Drawing.Size(168, 150);
            this.cardFourButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFourButton.TabIndex = 4;
            this.cardFourButton.TabStop = false;
            this.cardFourButton.Click += new System.EventHandler(this.cardFourButton_Click);
            // 
            // cardThreeButton
            // 
            this.cardThreeButton.Image = global::Card_Identifier.Properties.Resources.Jack_Clubs;
            this.cardThreeButton.Location = new System.Drawing.Point(367, 73);
            this.cardThreeButton.Name = "cardThreeButton";
            this.cardThreeButton.Size = new System.Drawing.Size(168, 150);
            this.cardThreeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardThreeButton.TabIndex = 3;
            this.cardThreeButton.TabStop = false;
            this.cardThreeButton.Click += new System.EventHandler(this.cardThreeButton_Click);
            // 
            // cardTwoButton
            // 
            this.cardTwoButton.Image = global::Card_Identifier.Properties.Resources._6_Hearts;
            this.cardTwoButton.Location = new System.Drawing.Point(207, 73);
            this.cardTwoButton.Name = "cardTwoButton";
            this.cardTwoButton.Size = new System.Drawing.Size(168, 150);
            this.cardTwoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardTwoButton.TabIndex = 2;
            this.cardTwoButton.TabStop = false;
            this.cardTwoButton.Click += new System.EventHandler(this.cardTwoButton_Click);
            // 
            // cardOneButton
            // 
            this.cardOneButton.Image = global::Card_Identifier.Properties.Resources._2_Clubs;
            this.cardOneButton.Location = new System.Drawing.Point(53, 73);
            this.cardOneButton.Name = "cardOneButton";
            this.cardOneButton.Size = new System.Drawing.Size(168, 150);
            this.cardOneButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardOneButton.TabIndex = 1;
            this.cardOneButton.TabStop = false;
            this.cardOneButton.Click += new System.EventHandler(this.cardOneButton_Click);
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameLabel.Location = new System.Drawing.Point(292, 254);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(320, 52);
            this.cardNameLabel.TabIndex = 6;
            this.cardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(414, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 389);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardNameLabel);
            this.Controls.Add(this.cardFiveButton);
            this.Controls.Add(this.cardFourButton);
            this.Controls.Add(this.cardThreeButton);
            this.Controls.Add(this.cardTwoButton);
            this.Controls.Add(this.cardOneButton);
            this.Controls.Add(this.directionsLabel);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardFiveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOneButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.PictureBox cardOneButton;
        private System.Windows.Forms.PictureBox cardTwoButton;
        private System.Windows.Forms.PictureBox cardThreeButton;
        private System.Windows.Forms.PictureBox cardFourButton;
        private System.Windows.Forms.PictureBox cardFiveButton;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

