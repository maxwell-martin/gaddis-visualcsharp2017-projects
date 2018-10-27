namespace MailingListOrNot
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.telephoneTB = new System.Windows.Forms.TextBox();
            this.mailingListCheckBox = new System.Windows.Forms.CheckBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(221, 26);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(124, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Create an account";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(23, 151);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(23, 222);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(107, 17);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(142, 88);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(410, 22);
            this.nameTB.TabIndex = 4;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(142, 146);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(410, 22);
            this.addressTB.TabIndex = 5;
            // 
            // telephoneTB
            // 
            this.telephoneTB.Location = new System.Drawing.Point(142, 219);
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(410, 22);
            this.telephoneTB.TabIndex = 6;
            // 
            // mailingListCheckBox
            // 
            this.mailingListCheckBox.AutoSize = true;
            this.mailingListCheckBox.Location = new System.Drawing.Point(233, 302);
            this.mailingListCheckBox.Name = "mailingListCheckBox";
            this.mailingListCheckBox.Size = new System.Drawing.Size(148, 21);
            this.mailingListCheckBox.TabIndex = 7;
            this.mailingListCheckBox.Text = "Add to mailing list?";
            this.mailingListCheckBox.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(212, 393);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(143, 45);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 486);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.mailingListCheckBox);
            this.Controls.Add(this.telephoneTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Mailing List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox telephoneTB;
        private System.Windows.Forms.CheckBox mailingListCheckBox;
        private System.Windows.Forms.Button signUpButton;
    }
}

