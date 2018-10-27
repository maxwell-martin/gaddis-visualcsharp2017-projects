namespace Email_Address_Book
{
    partial class InformationForm
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
            this.nameODLabel = new System.Windows.Forms.Label();
            this.emailODLabel = new System.Windows.Forms.Label();
            this.phoneNumberODLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameODLabel
            // 
            this.nameODLabel.AutoSize = true;
            this.nameODLabel.Location = new System.Drawing.Point(86, 68);
            this.nameODLabel.Name = "nameODLabel";
            this.nameODLabel.Size = new System.Drawing.Size(45, 17);
            this.nameODLabel.TabIndex = 0;
            this.nameODLabel.Text = "Name";
            // 
            // emailODLabel
            // 
            this.emailODLabel.AutoSize = true;
            this.emailODLabel.Location = new System.Drawing.Point(85, 135);
            this.emailODLabel.Name = "emailODLabel";
            this.emailODLabel.Size = new System.Drawing.Size(46, 17);
            this.emailODLabel.TabIndex = 1;
            this.emailODLabel.Text = "Email:";
            // 
            // phoneNumberODLabel
            // 
            this.phoneNumberODLabel.AutoSize = true;
            this.phoneNumberODLabel.Location = new System.Drawing.Point(28, 213);
            this.phoneNumberODLabel.Name = "phoneNumberODLabel";
            this.phoneNumberODLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberODLabel.TabIndex = 2;
            this.phoneNumberODLabel.Text = "Phone Number";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(172, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(256, 37);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Location = new System.Drawing.Point(172, 115);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(256, 37);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneNumberLabel.Location = new System.Drawing.Point(172, 193);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(256, 37);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 302);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneNumberODLabel);
            this.Controls.Add(this.emailODLabel);
            this.Controls.Add(this.nameODLabel);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameODLabel;
        private System.Windows.Forms.Label emailODLabel;
        private System.Windows.Forms.Label phoneNumberODLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label phoneNumberLabel;
    }
}