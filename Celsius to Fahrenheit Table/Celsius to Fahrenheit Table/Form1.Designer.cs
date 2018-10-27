namespace Celsius_to_Fahrenheit_Table
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
            this.temperaturesListBox = new System.Windows.Forms.ListBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.temperaturesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // temperaturesListBox
            // 
            this.temperaturesListBox.FormattingEnabled = true;
            this.temperaturesListBox.ItemHeight = 16;
            this.temperaturesListBox.Location = new System.Drawing.Point(257, 164);
            this.temperaturesListBox.Name = "temperaturesListBox";
            this.temperaturesListBox.Size = new System.Drawing.Size(350, 228);
            this.temperaturesListBox.TabIndex = 0;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(166, 21);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(285, 56);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "This program displays all Celsius temperatures, 0 through 20, and their Fahrenhei" +
    "t equivalents.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(261, 96);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(96, 41);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // temperaturesListView
            // 
            this.temperaturesListView.Location = new System.Drawing.Point(12, 164);
            this.temperaturesListView.Name = "temperaturesListView";
            this.temperaturesListView.Size = new System.Drawing.Size(225, 228);
            this.temperaturesListView.TabIndex = 3;
            this.temperaturesListView.UseCompatibleStateImageBehavior = false;
            this.temperaturesListView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 426);
            this.Controls.Add(this.temperaturesListView);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.temperaturesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox temperaturesListBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListView temperaturesListView;
    }
}

