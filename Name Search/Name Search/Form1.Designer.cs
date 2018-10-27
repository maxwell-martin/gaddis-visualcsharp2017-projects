namespace Name_Search
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
            this.boyNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.boyNameLabel = new System.Windows.Forms.Label();
            this.girlNameLabel = new System.Windows.Forms.Label();
            this.girlNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(94, 29);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(209, 72);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Type in a name(s) and click search to see if it is one of the most popular names " +
    "given to boys or girls from 2000 to 2009.";
            // 
            // boyNameTextBox
            // 
            this.boyNameTextBox.Location = new System.Drawing.Point(71, 147);
            this.boyNameTextBox.Name = "boyNameTextBox";
            this.boyNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.boyNameTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(154, 197);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 38);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // boyNameLabel
            // 
            this.boyNameLabel.AutoSize = true;
            this.boyNameLabel.Location = new System.Drawing.Point(104, 127);
            this.boyNameLabel.Name = "boyNameLabel";
            this.boyNameLabel.Size = new System.Drawing.Size(32, 17);
            this.boyNameLabel.TabIndex = 3;
            this.boyNameLabel.Text = "Boy";
            // 
            // girlNameLabel
            // 
            this.girlNameLabel.AutoSize = true;
            this.girlNameLabel.Location = new System.Drawing.Point(254, 127);
            this.girlNameLabel.Name = "girlNameLabel";
            this.girlNameLabel.Size = new System.Drawing.Size(30, 17);
            this.girlNameLabel.TabIndex = 4;
            this.girlNameLabel.Text = "Girl";
            // 
            // girlNameTextBox
            // 
            this.girlNameTextBox.Location = new System.Drawing.Point(217, 147);
            this.girlNameTextBox.Name = "girlNameTextBox";
            this.girlNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.girlNameTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 272);
            this.Controls.Add(this.girlNameTextBox);
            this.Controls.Add(this.girlNameLabel);
            this.Controls.Add(this.boyNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.boyNameTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox boyNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label boyNameLabel;
        private System.Windows.Forms.Label girlNameLabel;
        private System.Windows.Forms.TextBox girlNameTextBox;
    }
}

