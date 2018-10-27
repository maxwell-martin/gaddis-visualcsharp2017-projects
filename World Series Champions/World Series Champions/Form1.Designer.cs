namespace World_Series_Champions
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(142, 34);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(301, 59);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Choose a team to see how many times they have won the World Series in the time pe" +
    "riod 1903-2012.";
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(91, 105);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(410, 276);
            this.teamsListBox.TabIndex = 1;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 440);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "World Series Champions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.ListBox teamsListBox;
    }
}

