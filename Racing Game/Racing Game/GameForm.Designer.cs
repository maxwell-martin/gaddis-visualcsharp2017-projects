namespace Racing_Game
{
    partial class GameForm
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
            this.speedPromptLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.breakButton = new System.Windows.Forms.Button();
            this.accelarateButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.carInfoLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speedPromptLabel
            // 
            this.speedPromptLabel.AutoSize = true;
            this.speedPromptLabel.Location = new System.Drawing.Point(322, 274);
            this.speedPromptLabel.Name = "speedPromptLabel";
            this.speedPromptLabel.Size = new System.Drawing.Size(49, 17);
            this.speedPromptLabel.TabIndex = 7;
            this.speedPromptLabel.Text = "Speed";
            // 
            // speedLabel
            // 
            this.speedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedLabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.Gold;
            this.speedLabel.Location = new System.Drawing.Point(287, 305);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(122, 60);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakButton
            // 
            this.breakButton.Location = new System.Drawing.Point(414, 141);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(106, 89);
            this.breakButton.TabIndex = 5;
            this.breakButton.Text = "Break";
            this.breakButton.UseVisualStyleBackColor = true;
            this.breakButton.Click += new System.EventHandler(this.breakButton_Click);
            // 
            // accelarateButton
            // 
            this.accelarateButton.Location = new System.Drawing.Point(166, 141);
            this.accelarateButton.Name = "accelarateButton";
            this.accelarateButton.Size = new System.Drawing.Size(106, 89);
            this.accelarateButton.TabIndex = 4;
            this.accelarateButton.Text = "Accelerate";
            this.accelarateButton.UseVisualStyleBackColor = true;
            this.accelarateButton.Click += new System.EventHandler(this.accelarateButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearLabel.Location = new System.Drawing.Point(244, 54);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(100, 46);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carInfoLabel
            // 
            this.carInfoLabel.AutoSize = true;
            this.carInfoLabel.Location = new System.Drawing.Point(332, 19);
            this.carInfoLabel.Name = "carInfoLabel";
            this.carInfoLabel.Size = new System.Drawing.Size(30, 17);
            this.carInfoLabel.TabIndex = 9;
            this.carInfoLabel.Text = "Car";
            // 
            // makeLabel
            // 
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.makeLabel.Location = new System.Drawing.Point(350, 54);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(100, 46);
            this.makeLabel.TabIndex = 10;
            this.makeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 398);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.carInfoLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.speedPromptLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.breakButton);
            this.Controls.Add(this.accelarateButton);
            this.Name = "GameForm";
            this.Text = "Racing Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedPromptLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.Button accelarateButton;
        private System.Windows.Forms.Label carInfoLabel;
        public System.Windows.Forms.Label makeLabel;
        public System.Windows.Forms.Label yearLabel;
    }
}