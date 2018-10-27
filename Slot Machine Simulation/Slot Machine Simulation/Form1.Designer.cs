namespace Slot_Machine_Simulation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            this.bettingLabel = new System.Windows.Forms.Label();
            this.amountInsertedTextBox = new System.Windows.Forms.TextBox();
            this.fruitImagelist = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(62, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(256, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(450, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(355, 294);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(215, 294);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(90, 38);
            this.spinButton.TabIndex = 1;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // bettingLabel
            // 
            this.bettingLabel.AutoSize = true;
            this.bettingLabel.Location = new System.Drawing.Point(212, 238);
            this.bettingLabel.Name = "bettingLabel";
            this.bettingLabel.Size = new System.Drawing.Size(127, 17);
            this.bettingLabel.TabIndex = 5;
            this.bettingLabel.Text = "Amount Inserted: $";
            // 
            // amountInsertedTextBox
            // 
            this.amountInsertedTextBox.Location = new System.Drawing.Point(345, 235);
            this.amountInsertedTextBox.Name = "amountInsertedTextBox";
            this.amountInsertedTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountInsertedTextBox.TabIndex = 0;
            // 
            // fruitImagelist
            // 
            this.fruitImagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImagelist.ImageStream")));
            this.fruitImagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImagelist.Images.SetKeyName(0, "Apple.bmp");
            this.fruitImagelist.Images.SetKeyName(1, "Banana.bmp");
            this.fruitImagelist.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitImagelist.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitImagelist.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitImagelist.Images.SetKeyName(5, "Lime.bmp");
            this.fruitImagelist.Images.SetKeyName(6, "Orange.bmp");
            this.fruitImagelist.Images.SetKeyName(7, "Pear.bmp");
            this.fruitImagelist.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitImagelist.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 364);
            this.Controls.Add(this.amountInsertedTextBox);
            this.Controls.Add(this.bettingLabel);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label bettingLabel;
        private System.Windows.Forms.TextBox amountInsertedTextBox;
        private System.Windows.Forms.ImageList fruitImagelist;
    }
}

