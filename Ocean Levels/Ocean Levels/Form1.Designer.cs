namespace Ocean_Levels
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.oceanLevelListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(186, 312);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(111, 32);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(154, 22);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(193, 63);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Press calculate to see how much the ocean\'s level will rise over the next 10 year" +
    "s.";
            // 
            // oceanLevelListBox
            // 
            this.oceanLevelListBox.FormattingEnabled = true;
            this.oceanLevelListBox.ItemHeight = 16;
            this.oceanLevelListBox.Location = new System.Drawing.Point(75, 88);
            this.oceanLevelListBox.Name = "oceanLevelListBox";
            this.oceanLevelListBox.Size = new System.Drawing.Size(344, 196);
            this.oceanLevelListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 379);
            this.Controls.Add(this.oceanLevelListBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Ocean Levels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ListBox oceanLevelListBox;
    }
}

