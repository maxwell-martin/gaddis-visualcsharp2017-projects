namespace Random_Card
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getCardButton = new System.Windows.Forms.Button();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getCardButton
            // 
            this.getCardButton.Location = new System.Drawing.Point(116, 126);
            this.getCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getCardButton.Name = "getCardButton";
            this.getCardButton.Size = new System.Drawing.Size(100, 44);
            this.getCardButton.TabIndex = 3;
            this.getCardButton.Text = "Get Random Card";
            this.getCardButton.UseVisualStyleBackColor = true;
            this.getCardButton.Click += new System.EventHandler(this.getCardButton_Click);
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Image = global::Random_Card.Properties.Resources.Backface_Blue;
            this.cardPictureBox.Location = new System.Drawing.Point(132, 16);
            this.cardPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(67, 86);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox.TabIndex = 2;
            this.cardPictureBox.TabStop = false;
            // 
            // cardImageList
            // 
            this.cardImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImageList.ImageStream")));
            this.cardImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImageList.Images.SetKeyName(0, "2_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(2, "2_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(3, "2_Spades.bmp");
            this.cardImageList.Images.SetKeyName(4, "3_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(6, "3_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(7, "3_Spades.bmp");
            this.cardImageList.Images.SetKeyName(8, "4_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(10, "4_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(11, "4_Spades.bmp");
            this.cardImageList.Images.SetKeyName(12, "5_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(14, "5_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(15, "5_Spades.bmp");
            this.cardImageList.Images.SetKeyName(16, "6_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(18, "6_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(19, "6_Spades.bmp");
            this.cardImageList.Images.SetKeyName(20, "7_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(22, "7_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(23, "7_Spades.bmp");
            this.cardImageList.Images.SetKeyName(24, "8_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(26, "8_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(27, "8_Spades.bmp");
            this.cardImageList.Images.SetKeyName(28, "9_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(30, "9_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(31, "9_Spades.bmp");
            this.cardImageList.Images.SetKeyName(32, "10_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(34, "10_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(35, "10_Spades.bmp");
            this.cardImageList.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.cardImageList.Images.SetKeyName(40, "Jack_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(41, "Jack_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(42, "Jack_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(43, "Jack_Spades.bmp");
            this.cardImageList.Images.SetKeyName(44, "Joker_Black.bmp");
            this.cardImageList.Images.SetKeyName(45, "Joker_Red.bmp");
            this.cardImageList.Images.SetKeyName(46, "King_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(47, "King_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(48, "King_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(49, "King_Spades.bmp");
            this.cardImageList.Images.SetKeyName(50, "Queen_Clubs.bmp");
            this.cardImageList.Images.SetKeyName(51, "Queen_Diamonds.bmp");
            this.cardImageList.Images.SetKeyName(52, "Queen_Hearts.bmp");
            this.cardImageList.Images.SetKeyName(53, "Queen_Spades.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 185);
            this.Controls.Add(this.getCardButton);
            this.Controls.Add(this.cardPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Card";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCardButton;
        private System.Windows.Forms.PictureBox cardPictureBox;
        private System.Windows.Forms.ImageList cardImageList;
    }
}

