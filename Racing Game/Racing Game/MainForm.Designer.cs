namespace Racing_Game
{
    partial class MainForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.carYearPromptLabel = new System.Windows.Forms.Label();
            this.carMakePromptLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(66, 49);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(199, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Racing Game!";
            // 
            // carYearPromptLabel
            // 
            this.carYearPromptLabel.AutoSize = true;
            this.carYearPromptLabel.Location = new System.Drawing.Point(66, 115);
            this.carYearPromptLabel.Name = "carYearPromptLabel";
            this.carYearPromptLabel.Size = new System.Drawing.Size(68, 17);
            this.carYearPromptLabel.TabIndex = 1;
            this.carYearPromptLabel.Text = "Car Year:";
            // 
            // carMakePromptLabel
            // 
            this.carMakePromptLabel.AutoSize = true;
            this.carMakePromptLabel.Location = new System.Drawing.Point(62, 184);
            this.carMakePromptLabel.Name = "carMakePromptLabel";
            this.carMakePromptLabel.Size = new System.Drawing.Size(72, 17);
            this.carMakePromptLabel.TabIndex = 2;
            this.carMakePromptLabel.Text = "Car Make:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(165, 110);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearTextBox.TabIndex = 3;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(165, 179);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 22);
            this.makeTextBox.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(110, 272);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(113, 52);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 395);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.carMakePromptLabel);
            this.Controls.Add(this.carYearPromptLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MainForm";
            this.Text = "Racing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label carYearPromptLabel;
        private System.Windows.Forms.Label carMakePromptLabel;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.TextBox yearTextBox;
        public System.Windows.Forms.TextBox makeTextBox;
    }
}

