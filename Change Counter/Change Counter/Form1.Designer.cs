namespace Change_Counter
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.fiveCents = new System.Windows.Forms.PictureBox();
            this.tenCents = new System.Windows.Forms.PictureBox();
            this.twentyfiveCents = new System.Windows.Forms.PictureBox();
            this.fiftyCents = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCents)).BeginInit();
            this.SuspendLayout();
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Location = new System.Drawing.Point(285, 32);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(102, 17);
            this.directionsLabel.TabIndex = 0;
            this.directionsLabel.Text = "Click the coins.";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(491, 150);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(44, 17);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(389, 184);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(250, 37);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiveCents
            // 
            this.fiveCents.Image = global::Change_Counter.Properties.Resources._5cents;
            this.fiveCents.Location = new System.Drawing.Point(12, 100);
            this.fiveCents.Name = "fiveCents";
            this.fiveCents.Size = new System.Drawing.Size(200, 100);
            this.fiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiveCents.TabIndex = 3;
            this.fiveCents.TabStop = false;
            this.fiveCents.Click += new System.EventHandler(this.fiveCents_Click);
            // 
            // tenCents
            // 
            this.tenCents.Image = global::Change_Counter.Properties.Resources._10cents;
            this.tenCents.Location = new System.Drawing.Point(175, 100);
            this.tenCents.Name = "tenCents";
            this.tenCents.Size = new System.Drawing.Size(200, 100);
            this.tenCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenCents.TabIndex = 4;
            this.tenCents.TabStop = false;
            this.tenCents.Click += new System.EventHandler(this.tenCents_Click);
            // 
            // twentyfiveCents
            // 
            this.twentyfiveCents.Image = global::Change_Counter.Properties.Resources._25cents;
            this.twentyfiveCents.Location = new System.Drawing.Point(12, 216);
            this.twentyfiveCents.Name = "twentyfiveCents";
            this.twentyfiveCents.Size = new System.Drawing.Size(200, 100);
            this.twentyfiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twentyfiveCents.TabIndex = 5;
            this.twentyfiveCents.TabStop = false;
            this.twentyfiveCents.Click += new System.EventHandler(this.twentyfiveCents_Click);
            // 
            // fiftyCents
            // 
            this.fiftyCents.Image = global::Change_Counter.Properties.Resources._50cents;
            this.fiftyCents.Location = new System.Drawing.Point(175, 216);
            this.fiftyCents.Name = "fiftyCents";
            this.fiftyCents.Size = new System.Drawing.Size(200, 100);
            this.fiftyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiftyCents.TabIndex = 6;
            this.fiftyCents.TabStop = false;
            this.fiftyCents.Click += new System.EventHandler(this.fiftyCents_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(300, 380);
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
            this.ClientSize = new System.Drawing.Size(701, 466);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCents);
            this.Controls.Add(this.twentyfiveCents);
            this.Controls.Add(this.tenCents);
            this.Controls.Add(this.fiveCents);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.directionsLabel);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.fiveCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox fiveCents;
        private System.Windows.Forms.PictureBox tenCents;
        private System.Windows.Forms.PictureBox twentyfiveCents;
        private System.Windows.Forms.PictureBox fiftyCents;
        private System.Windows.Forms.Button exitButton;
    }
}

