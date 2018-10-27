namespace Color_Mixer
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
            this.firstColorGroupBox = new System.Windows.Forms.GroupBox();
            this.secondColorGroupBox = new System.Windows.Forms.GroupBox();
            this.mixButton = new System.Windows.Forms.Button();
            this.red1RadioButton = new System.Windows.Forms.RadioButton();
            this.blue1RadioButton = new System.Windows.Forms.RadioButton();
            this.yellow1RadioButton = new System.Windows.Forms.RadioButton();
            this.red2RadioButton = new System.Windows.Forms.RadioButton();
            this.blue2RadioButton = new System.Windows.Forms.RadioButton();
            this.yellow2RadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColorGroupBox.SuspendLayout();
            this.secondColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorGroupBox
            // 
            this.firstColorGroupBox.Controls.Add(this.yellow1RadioButton);
            this.firstColorGroupBox.Controls.Add(this.blue1RadioButton);
            this.firstColorGroupBox.Controls.Add(this.red1RadioButton);
            this.firstColorGroupBox.Location = new System.Drawing.Point(62, 47);
            this.firstColorGroupBox.Name = "firstColorGroupBox";
            this.firstColorGroupBox.Size = new System.Drawing.Size(226, 172);
            this.firstColorGroupBox.TabIndex = 0;
            this.firstColorGroupBox.TabStop = false;
            this.firstColorGroupBox.Text = "Select the First Color";
            // 
            // secondColorGroupBox
            // 
            this.secondColorGroupBox.Controls.Add(this.yellow2RadioButton);
            this.secondColorGroupBox.Controls.Add(this.blue2RadioButton);
            this.secondColorGroupBox.Controls.Add(this.red2RadioButton);
            this.secondColorGroupBox.Location = new System.Drawing.Point(374, 47);
            this.secondColorGroupBox.Name = "secondColorGroupBox";
            this.secondColorGroupBox.Size = new System.Drawing.Size(226, 172);
            this.secondColorGroupBox.TabIndex = 1;
            this.secondColorGroupBox.TabStop = false;
            this.secondColorGroupBox.Text = "Select the Second Color";
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(117, 256);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(128, 61);
            this.mixButton.TabIndex = 7;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // red1RadioButton
            // 
            this.red1RadioButton.AutoSize = true;
            this.red1RadioButton.Checked = true;
            this.red1RadioButton.Location = new System.Drawing.Point(55, 34);
            this.red1RadioButton.Name = "red1RadioButton";
            this.red1RadioButton.Size = new System.Drawing.Size(55, 21);
            this.red1RadioButton.TabIndex = 1;
            this.red1RadioButton.TabStop = true;
            this.red1RadioButton.Text = "Red";
            this.red1RadioButton.UseVisualStyleBackColor = true;
            // 
            // blue1RadioButton
            // 
            this.blue1RadioButton.AutoSize = true;
            this.blue1RadioButton.Location = new System.Drawing.Point(55, 77);
            this.blue1RadioButton.Name = "blue1RadioButton";
            this.blue1RadioButton.Size = new System.Drawing.Size(57, 21);
            this.blue1RadioButton.TabIndex = 2;
            this.blue1RadioButton.Text = "Blue";
            this.blue1RadioButton.UseVisualStyleBackColor = true;
            // 
            // yellow1RadioButton
            // 
            this.yellow1RadioButton.AutoSize = true;
            this.yellow1RadioButton.Location = new System.Drawing.Point(55, 123);
            this.yellow1RadioButton.Name = "yellow1RadioButton";
            this.yellow1RadioButton.Size = new System.Drawing.Size(69, 21);
            this.yellow1RadioButton.TabIndex = 3;
            this.yellow1RadioButton.Text = "Yellow";
            this.yellow1RadioButton.UseVisualStyleBackColor = true;
            // 
            // red2RadioButton
            // 
            this.red2RadioButton.AutoSize = true;
            this.red2RadioButton.Checked = true;
            this.red2RadioButton.Location = new System.Drawing.Point(51, 34);
            this.red2RadioButton.Name = "red2RadioButton";
            this.red2RadioButton.Size = new System.Drawing.Size(55, 21);
            this.red2RadioButton.TabIndex = 4;
            this.red2RadioButton.TabStop = true;
            this.red2RadioButton.Text = "Red";
            this.red2RadioButton.UseVisualStyleBackColor = true;
            // 
            // blue2RadioButton
            // 
            this.blue2RadioButton.AutoSize = true;
            this.blue2RadioButton.Location = new System.Drawing.Point(51, 77);
            this.blue2RadioButton.Name = "blue2RadioButton";
            this.blue2RadioButton.Size = new System.Drawing.Size(57, 21);
            this.blue2RadioButton.TabIndex = 5;
            this.blue2RadioButton.Text = "Blue";
            this.blue2RadioButton.UseVisualStyleBackColor = true;
            // 
            // yellow2RadioButton
            // 
            this.yellow2RadioButton.AutoSize = true;
            this.yellow2RadioButton.Location = new System.Drawing.Point(51, 123);
            this.yellow2RadioButton.Name = "yellow2RadioButton";
            this.yellow2RadioButton.Size = new System.Drawing.Size(69, 21);
            this.yellow2RadioButton.TabIndex = 6;
            this.yellow2RadioButton.Text = "Yellow";
            this.yellow2RadioButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(425, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 61);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 379);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondColorGroupBox);
            this.Controls.Add(this.firstColorGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Mixer";
            this.firstColorGroupBox.ResumeLayout(false);
            this.firstColorGroupBox.PerformLayout();
            this.secondColorGroupBox.ResumeLayout(false);
            this.secondColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorGroupBox;
        private System.Windows.Forms.GroupBox secondColorGroupBox;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.RadioButton yellow1RadioButton;
        private System.Windows.Forms.RadioButton blue1RadioButton;
        private System.Windows.Forms.RadioButton red1RadioButton;
        private System.Windows.Forms.RadioButton yellow2RadioButton;
        private System.Windows.Forms.RadioButton blue2RadioButton;
        private System.Windows.Forms.RadioButton red2RadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

