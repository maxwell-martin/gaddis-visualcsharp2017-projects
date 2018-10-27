namespace Food_Facts
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
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.foodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.muffinRadioButton);
            this.foodGroupBox.Controls.Add(this.popcornRadioButton);
            this.foodGroupBox.Controls.Add(this.bananaRadioButton);
            this.foodGroupBox.Location = new System.Drawing.Point(32, 40);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(407, 179);
            this.foodGroupBox.TabIndex = 0;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "Select a Food";
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Checked = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(39, 40);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(89, 21);
            this.bananaRadioButton.TabIndex = 1;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Location = new System.Drawing.Point(39, 82);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(209, 21);
            this.popcornRadioButton.TabIndex = 2;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1 cup of air-popped popcorn";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(39, 129);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(179, 21);
            this.muffinRadioButton.TabIndex = 3;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 large blueberry muffin";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(92, 250);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(98, 51);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Food Facts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(288, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 51);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 346);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.foodGroupBox);
            this.Name = "MainForm";
            this.Text = "Food Facts";
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

