namespace Joke_and_Punch_Line
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
            this.jokeAndPunchLineLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jokeAndPunchLineLabel
            // 
            this.jokeAndPunchLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jokeAndPunchLineLabel.Location = new System.Drawing.Point(153, 85);
            this.jokeAndPunchLineLabel.Name = "jokeAndPunchLineLabel";
            this.jokeAndPunchLineLabel.Size = new System.Drawing.Size(321, 48);
            this.jokeAndPunchLineLabel.TabIndex = 0;
            this.jokeAndPunchLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(130, 208);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(127, 73);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(368, 208);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(127, 73);
            this.punchLineButton.TabIndex = 2;
            this.punchLineButton.Text = "Punch Line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 350);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.jokeAndPunchLineLabel);
            this.Name = "Form1";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label jokeAndPunchLineLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchLineButton;
    }
}

