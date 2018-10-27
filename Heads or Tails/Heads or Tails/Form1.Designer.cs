namespace Heads_or_Tails
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
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsImage = new System.Windows.Forms.PictureBox();
            this.headsImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.AutoSize = true;
            this.showHeadsButton.Location = new System.Drawing.Point(146, 304);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(97, 27);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.AutoSize = true;
            this.showTailsButton.Location = new System.Drawing.Point(495, 304);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(86, 27);
            this.showTailsButton.TabIndex = 1;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(331, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsImage
            // 
            this.tailsImage.Image = global::Heads_or_Tails.Properties.Resources.Tails2;
            this.tailsImage.Location = new System.Drawing.Point(410, 51);
            this.tailsImage.Name = "tailsImage";
            this.tailsImage.Size = new System.Drawing.Size(253, 173);
            this.tailsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsImage.TabIndex = 4;
            this.tailsImage.TabStop = false;
            this.tailsImage.Visible = false;
            // 
            // headsImage
            // 
            this.headsImage.Image = global::Heads_or_Tails.Properties.Resources.Heads2;
            this.headsImage.Location = new System.Drawing.Point(68, 51);
            this.headsImage.Name = "headsImage";
            this.headsImage.Size = new System.Drawing.Size(253, 180);
            this.headsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsImage.TabIndex = 3;
            this.headsImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 420);
            this.Controls.Add(this.tailsImage);
            this.Controls.Add(this.headsImage);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Name = "Form1";
            this.Text = "Heads or Tails?";
            ((System.ComponentModel.ISupportInitialize)(this.tailsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headsImage;
        private System.Windows.Forms.PictureBox tailsImage;
    }
}

