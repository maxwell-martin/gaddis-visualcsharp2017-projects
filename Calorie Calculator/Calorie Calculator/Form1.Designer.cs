namespace Calorie_Calculator
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
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            this.orangePictureBox = new System.Windows.Forms.PictureBox();
            this.pearPictureBox = new System.Windows.Forms.PictureBox();
            this.applePictureBox = new System.Windows.Forms.PictureBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.Image = global::Calorie_Calculator.Properties.Resources.BananaCalories;
            this.bananaPictureBox.Location = new System.Drawing.Point(91, 93);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(128, 155);
            this.bananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bananaPictureBox.TabIndex = 0;
            this.bananaPictureBox.TabStop = false;
            this.bananaPictureBox.Click += new System.EventHandler(this.bananaPictureBox_Click);
            // 
            // orangePictureBox
            // 
            this.orangePictureBox.Image = global::Calorie_Calculator.Properties.Resources.OrangeCalories;
            this.orangePictureBox.Location = new System.Drawing.Point(91, 278);
            this.orangePictureBox.Name = "orangePictureBox";
            this.orangePictureBox.Size = new System.Drawing.Size(128, 155);
            this.orangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangePictureBox.TabIndex = 1;
            this.orangePictureBox.TabStop = false;
            this.orangePictureBox.Click += new System.EventHandler(this.orangePictureBox_Click);
            // 
            // pearPictureBox
            // 
            this.pearPictureBox.Image = global::Calorie_Calculator.Properties.Resources.PearCalories;
            this.pearPictureBox.Location = new System.Drawing.Point(281, 278);
            this.pearPictureBox.Name = "pearPictureBox";
            this.pearPictureBox.Size = new System.Drawing.Size(128, 155);
            this.pearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearPictureBox.TabIndex = 2;
            this.pearPictureBox.TabStop = false;
            this.pearPictureBox.Click += new System.EventHandler(this.pearPictureBox_Click);
            // 
            // applePictureBox
            // 
            this.applePictureBox.Image = global::Calorie_Calculator.Properties.Resources.AppleCalories;
            this.applePictureBox.Location = new System.Drawing.Point(281, 93);
            this.applePictureBox.Name = "applePictureBox";
            this.applePictureBox.Size = new System.Drawing.Size(128, 155);
            this.applePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.applePictureBox.TabIndex = 3;
            this.applePictureBox.TabStop = false;
            this.applePictureBox.Click += new System.EventHandler(this.applePictureBox_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(495, 119);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(127, 20);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Total Calories";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Location = new System.Drawing.Point(488, 150);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(147, 38);
            this.caloriesLabel.TabIndex = 5;
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(530, 278);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 29);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(530, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 539);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.applePictureBox);
            this.Controls.Add(this.pearPictureBox);
            this.Controls.Add(this.orangePictureBox);
            this.Controls.Add(this.bananaPictureBox);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox orangePictureBox;
        private System.Windows.Forms.PictureBox pearPictureBox;
        private System.Windows.Forms.PictureBox applePictureBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

