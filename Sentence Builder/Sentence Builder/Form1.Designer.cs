namespace Sentence_Builder
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
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.aButton = new System.Windows.Forms.Button();
            this.bigButton = new System.Windows.Forms.Button();
            this.manButton = new System.Windows.Forms.Button();
            this.laughedAtButton = new System.Windows.Forms.Button();
            this.theButton = new System.Windows.Forms.Button();
            this.jokeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sentenceLabel.Location = new System.Drawing.Point(243, 264);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(376, 45);
            this.sentenceLabel.TabIndex = 0;
            this.sentenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aButton
            // 
            this.aButton.AutoSize = true;
            this.aButton.Location = new System.Drawing.Point(243, 78);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(75, 37);
            this.aButton.TabIndex = 1;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // bigButton
            // 
            this.bigButton.AutoSize = true;
            this.bigButton.Location = new System.Drawing.Point(402, 78);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(75, 37);
            this.bigButton.TabIndex = 2;
            this.bigButton.Text = "big";
            this.bigButton.UseVisualStyleBackColor = true;
            this.bigButton.Click += new System.EventHandler(this.bigButton_Click);
            // 
            // manButton
            // 
            this.manButton.AutoSize = true;
            this.manButton.Location = new System.Drawing.Point(544, 78);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(75, 37);
            this.manButton.TabIndex = 3;
            this.manButton.Text = "man";
            this.manButton.UseVisualStyleBackColor = true;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // laughedAtButton
            // 
            this.laughedAtButton.AutoSize = true;
            this.laughedAtButton.Location = new System.Drawing.Point(243, 159);
            this.laughedAtButton.Name = "laughedAtButton";
            this.laughedAtButton.Size = new System.Drawing.Size(85, 37);
            this.laughedAtButton.TabIndex = 4;
            this.laughedAtButton.Text = "laughed at";
            this.laughedAtButton.UseVisualStyleBackColor = true;
            this.laughedAtButton.Click += new System.EventHandler(this.laughedAtButton_Click);
            // 
            // theButton
            // 
            this.theButton.AutoSize = true;
            this.theButton.Location = new System.Drawing.Point(402, 169);
            this.theButton.Name = "theButton";
            this.theButton.Size = new System.Drawing.Size(75, 27);
            this.theButton.TabIndex = 5;
            this.theButton.Text = "the";
            this.theButton.UseVisualStyleBackColor = true;
            this.theButton.Click += new System.EventHandler(this.theButton_Click);
            // 
            // jokeButton
            // 
            this.jokeButton.AutoSize = true;
            this.jokeButton.Location = new System.Drawing.Point(544, 169);
            this.jokeButton.Name = "jokeButton";
            this.jokeButton.Size = new System.Drawing.Size(75, 27);
            this.jokeButton.TabIndex = 6;
            this.jokeButton.Text = "joke";
            this.jokeButton.UseVisualStyleBackColor = true;
            this.jokeButton.Click += new System.EventHandler(this.jokeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(303, 387);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 27);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(472, 387);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 27);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 550);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.jokeButton);
            this.Controls.Add(this.theButton);
            this.Controls.Add(this.laughedAtButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.bigButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.sentenceLabel);
            this.Name = "Form1";
            this.Text = "Sentence Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button bigButton;
        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button laughedAtButton;
        private System.Windows.Forms.Button theButton;
        private System.Windows.Forms.Button jokeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

