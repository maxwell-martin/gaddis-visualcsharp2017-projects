namespace Clickable_Number_Images
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
            this.numberFiveButton = new System.Windows.Forms.PictureBox();
            this.numberFourButton = new System.Windows.Forms.PictureBox();
            this.numberThreeButton = new System.Windows.Forms.PictureBox();
            this.numberTwoButton = new System.Windows.Forms.PictureBox();
            this.numberOneButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFourButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberThreeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOneButton)).BeginInit();
            this.SuspendLayout();
            // 
            // numberFiveButton
            // 
            this.numberFiveButton.Image = global::Clickable_Number_Images.Properties.Resources.Five;
            this.numberFiveButton.Location = new System.Drawing.Point(772, 54);
            this.numberFiveButton.Name = "numberFiveButton";
            this.numberFiveButton.Size = new System.Drawing.Size(136, 163);
            this.numberFiveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberFiveButton.TabIndex = 4;
            this.numberFiveButton.TabStop = false;
            this.numberFiveButton.Click += new System.EventHandler(this.numberFiveButton_Click);
            // 
            // numberFourButton
            // 
            this.numberFourButton.Image = global::Clickable_Number_Images.Properties.Resources.Four;
            this.numberFourButton.Location = new System.Drawing.Point(593, 54);
            this.numberFourButton.Name = "numberFourButton";
            this.numberFourButton.Size = new System.Drawing.Size(136, 163);
            this.numberFourButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberFourButton.TabIndex = 3;
            this.numberFourButton.TabStop = false;
            this.numberFourButton.Click += new System.EventHandler(this.numberFourButton_Click);
            // 
            // numberThreeButton
            // 
            this.numberThreeButton.Image = global::Clickable_Number_Images.Properties.Resources.Three;
            this.numberThreeButton.Location = new System.Drawing.Point(421, 54);
            this.numberThreeButton.Name = "numberThreeButton";
            this.numberThreeButton.Size = new System.Drawing.Size(136, 163);
            this.numberThreeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberThreeButton.TabIndex = 2;
            this.numberThreeButton.TabStop = false;
            this.numberThreeButton.Click += new System.EventHandler(this.numberThreeButton_Click);
            // 
            // numberTwoButton
            // 
            this.numberTwoButton.Image = global::Clickable_Number_Images.Properties.Resources.Two;
            this.numberTwoButton.Location = new System.Drawing.Point(254, 54);
            this.numberTwoButton.Name = "numberTwoButton";
            this.numberTwoButton.Size = new System.Drawing.Size(136, 163);
            this.numberTwoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberTwoButton.TabIndex = 1;
            this.numberTwoButton.TabStop = false;
            this.numberTwoButton.Click += new System.EventHandler(this.numberTwoButton_Click);
            // 
            // numberOneButton
            // 
            this.numberOneButton.Image = global::Clickable_Number_Images.Properties.Resources.One;
            this.numberOneButton.Location = new System.Drawing.Point(73, 54);
            this.numberOneButton.Name = "numberOneButton";
            this.numberOneButton.Size = new System.Drawing.Size(136, 163);
            this.numberOneButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberOneButton.TabIndex = 0;
            this.numberOneButton.TabStop = false;
            this.numberOneButton.Click += new System.EventHandler(this.numberOneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 286);
            this.Controls.Add(this.numberFiveButton);
            this.Controls.Add(this.numberFourButton);
            this.Controls.Add(this.numberThreeButton);
            this.Controls.Add(this.numberTwoButton);
            this.Controls.Add(this.numberOneButton);
            this.Name = "Form1";
            this.Text = "Clickable Number Images";
            ((System.ComponentModel.ISupportInitialize)(this.numberFiveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFourButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberThreeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOneButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox numberOneButton;
        private System.Windows.Forms.PictureBox numberTwoButton;
        private System.Windows.Forms.PictureBox numberThreeButton;
        private System.Windows.Forms.PictureBox numberFourButton;
        private System.Windows.Forms.PictureBox numberFiveButton;
    }
}

