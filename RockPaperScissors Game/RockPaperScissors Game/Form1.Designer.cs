namespace RockPaperScissors_Game
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
            this.introLabel = new System.Windows.Forms.Label();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.informationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(47, 35);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(578, 65);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "ROCK, PAPER, SCISSORS!";
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Location = new System.Drawing.Point(284, 171);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(66, 17);
            this.directionsLabel.TabIndex = 1;
            this.directionsLabel.Text = "Pick one.";
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(69, 228);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(142, 129);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "&Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(249, 228);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(142, 129);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "&Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(430, 228);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(142, 129);
            this.scissorsButton.TabIndex = 2;
            this.scissorsButton.Text = "&Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Location = new System.Drawing.Point(275, 420);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 47);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(246, 120);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(149, 17);
            this.informationLabel.TabIndex = 4;
            this.informationLabel.Text = "You vs. The Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(659, 479);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.introLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label informationLabel;
    }
}

