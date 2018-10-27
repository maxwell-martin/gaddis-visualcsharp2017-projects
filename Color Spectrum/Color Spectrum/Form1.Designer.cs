namespace Color_Spectrum
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
            this.violetLabel = new System.Windows.Forms.Label();
            this.indigoLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // violetLabel
            // 
            this.violetLabel.BackColor = System.Drawing.Color.Violet;
            this.violetLabel.Location = new System.Drawing.Point(507, 46);
            this.violetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.Size = new System.Drawing.Size(75, 28);
            this.violetLabel.TabIndex = 24;
            this.violetLabel.Click += new System.EventHandler(this.violetLabel_Click);
            // 
            // indigoLabel
            // 
            this.indigoLabel.BackColor = System.Drawing.Color.Indigo;
            this.indigoLabel.Location = new System.Drawing.Point(424, 46);
            this.indigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indigoLabel.Name = "indigoLabel";
            this.indigoLabel.Size = new System.Drawing.Size(75, 28);
            this.indigoLabel.TabIndex = 23;
            this.indigoLabel.Click += new System.EventHandler(this.indigoLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(341, 46);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(75, 28);
            this.blueLabel.TabIndex = 22;
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(259, 46);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(75, 28);
            this.greenLabel.TabIndex = 21;
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.Location = new System.Drawing.Point(176, 46);
            this.yellowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(75, 28);
            this.yellowLabel.TabIndex = 20;
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.Orange;
            this.orangeLabel.Location = new System.Drawing.Point(93, 46);
            this.orangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(75, 28);
            this.orangeLabel.TabIndex = 19;
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(11, 46);
            this.redLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(75, 28);
            this.redLabel.TabIndex = 18;
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(229, 94);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(133, 28);
            this.colorLabel.TabIndex = 17;
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(196, 16);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(200, 17);
            this.promptLabel.TabIndex = 16;
            this.promptLabel.Text = "Select a Color of the Spectrum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 138);
            this.Controls.Add(this.violetLabel);
            this.Controls.Add(this.indigoLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.promptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Color Spectrum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label violetLabel;
        private System.Windows.Forms.Label indigoLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label promptLabel;
    }
}

