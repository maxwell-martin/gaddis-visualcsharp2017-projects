namespace Charge_Account_Validation
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
            this.acctNumberTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.checkStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acctNumberTextBox
            // 
            this.acctNumberTextBox.Location = new System.Drawing.Point(179, 114);
            this.acctNumberTextBox.Name = "acctNumberTextBox";
            this.acctNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.acctNumberTextBox.TabIndex = 0;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(155, 78);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(152, 17);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Enter account number:";
            // 
            // checkStatusButton
            // 
            this.checkStatusButton.Location = new System.Drawing.Point(179, 181);
            this.checkStatusButton.Name = "checkStatusButton";
            this.checkStatusButton.Size = new System.Drawing.Size(100, 57);
            this.checkStatusButton.TabIndex = 2;
            this.checkStatusButton.Text = "Check Status";
            this.checkStatusButton.UseVisualStyleBackColor = true;
            this.checkStatusButton.Click += new System.EventHandler(this.checkStatusButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.checkStatusButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 339);
            this.Controls.Add(this.checkStatusButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.acctNumberTextBox);
            this.Name = "Form1";
            this.Text = "Charge Account Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acctNumberTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button checkStatusButton;
    }
}

