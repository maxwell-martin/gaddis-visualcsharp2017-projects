namespace Magic_Dates
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
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dayPromptLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(58, 38);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(137, 17);
            this.monthPromptLabel.TabIndex = 0;
            this.monthPromptLabel.Text = "Enter a month (MM):";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(58, 169);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(122, 17);
            this.yearPromptLabel.TabIndex = 1;
            this.yearPromptLabel.Text = "Enter a year (YY):";
            // 
            // dayPromptLabel
            // 
            this.dayPromptLabel.AutoSize = true;
            this.dayPromptLabel.Location = new System.Drawing.Point(58, 99);
            this.dayPromptLabel.Name = "dayPromptLabel";
            this.dayPromptLabel.Size = new System.Drawing.Size(119, 17);
            this.dayPromptLabel.TabIndex = 2;
            this.dayPromptLabel.Text = "Enter a day (DD):";
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(142, 229);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(106, 66);
            this.magicButton.TabIndex = 4;
            this.magicButton.Text = "Is the date magic?";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(218, 33);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 22);
            this.monthTextBox.TabIndex = 1;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(218, 94);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 22);
            this.dayTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(218, 169);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.magicButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 369);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.dayPromptLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Name = "Form1";
            this.Text = "Magic Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dayPromptLabel;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
    }
}

