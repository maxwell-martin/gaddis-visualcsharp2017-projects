namespace Dice_Simulator
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.side1PictureBox = new System.Windows.Forms.PictureBox();
            this.side2PictureBox = new System.Windows.Forms.PictureBox();
            this.side4PictureBox = new System.Windows.Forms.PictureBox();
            this.side5PictureBox = new System.Windows.Forms.PictureBox();
            this.side3PictureBox = new System.Windows.Forms.PictureBox();
            this.side6PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.side1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side6PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(205, 48);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(202, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Click the button to roll the dice.";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(250, 92);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(99, 48);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // side1PictureBox
            // 
            this.side1PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die1;
            this.side1PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side1PictureBox.Name = "side1PictureBox";
            this.side1PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side1PictureBox.TabIndex = 2;
            this.side1PictureBox.TabStop = false;
            this.side1PictureBox.Visible = false;
            // 
            // side2PictureBox
            // 
            this.side2PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die2;
            this.side2PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side2PictureBox.Name = "side2PictureBox";
            this.side2PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side2PictureBox.TabIndex = 3;
            this.side2PictureBox.TabStop = false;
            this.side2PictureBox.Visible = false;
            // 
            // side4PictureBox
            // 
            this.side4PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die4;
            this.side4PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side4PictureBox.Name = "side4PictureBox";
            this.side4PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side4PictureBox.TabIndex = 4;
            this.side4PictureBox.TabStop = false;
            this.side4PictureBox.Visible = false;
            // 
            // side5PictureBox
            // 
            this.side5PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die5;
            this.side5PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side5PictureBox.Name = "side5PictureBox";
            this.side5PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side5PictureBox.TabIndex = 5;
            this.side5PictureBox.TabStop = false;
            this.side5PictureBox.Visible = false;
            // 
            // side3PictureBox
            // 
            this.side3PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die3;
            this.side3PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side3PictureBox.Name = "side3PictureBox";
            this.side3PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side3PictureBox.TabIndex = 6;
            this.side3PictureBox.TabStop = false;
            this.side3PictureBox.Visible = false;
            // 
            // side6PictureBox
            // 
            this.side6PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die6;
            this.side6PictureBox.Location = new System.Drawing.Point(198, 205);
            this.side6PictureBox.Name = "side6PictureBox";
            this.side6PictureBox.Size = new System.Drawing.Size(219, 180);
            this.side6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.side6PictureBox.TabIndex = 7;
            this.side6PictureBox.TabStop = false;
            this.side6PictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 496);
            this.Controls.Add(this.side6PictureBox);
            this.Controls.Add(this.side3PictureBox);
            this.Controls.Add(this.side5PictureBox);
            this.Controls.Add(this.side4PictureBox);
            this.Controls.Add(this.side2PictureBox);
            this.Controls.Add(this.side1PictureBox);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.side1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side6PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox side1PictureBox;
        private System.Windows.Forms.PictureBox side2PictureBox;
        private System.Windows.Forms.PictureBox side4PictureBox;
        private System.Windows.Forms.PictureBox side5PictureBox;
        private System.Windows.Forms.PictureBox side3PictureBox;
        private System.Windows.Forms.PictureBox side6PictureBox;
    }
}

