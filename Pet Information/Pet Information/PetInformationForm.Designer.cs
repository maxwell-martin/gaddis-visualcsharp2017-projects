namespace Pet_Information
{
    partial class PetInformationForm
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
            this.agePromptLabel = new System.Windows.Forms.Label();
            this.typePromptLabel = new System.Windows.Forms.Label();
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agePromptLabel
            // 
            this.agePromptLabel.AutoSize = true;
            this.agePromptLabel.Location = new System.Drawing.Point(84, 229);
            this.agePromptLabel.Name = "agePromptLabel";
            this.agePromptLabel.Size = new System.Drawing.Size(62, 17);
            this.agePromptLabel.TabIndex = 7;
            this.agePromptLabel.Text = "Pet Age:";
            // 
            // typePromptLabel
            // 
            this.typePromptLabel.AutoSize = true;
            this.typePromptLabel.Location = new System.Drawing.Point(84, 149);
            this.typePromptLabel.Name = "typePromptLabel";
            this.typePromptLabel.Size = new System.Drawing.Size(69, 17);
            this.typePromptLabel.TabIndex = 6;
            this.typePromptLabel.Text = "Pet Type:";
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(84, 82);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(74, 17);
            this.namePromptLabel.TabIndex = 5;
            this.namePromptLabel.Text = "Pet Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(185, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 33);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.typeLabel.Location = new System.Drawing.Point(185, 133);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(111, 33);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ageLabel.Location = new System.Drawing.Point(185, 213);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(111, 33);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PetInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.agePromptLabel);
            this.Controls.Add(this.typePromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "PetInformationForm";
            this.Text = "Pet Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agePromptLabel;
        private System.Windows.Forms.Label typePromptLabel;
        private System.Windows.Forms.Label namePromptLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label typeLabel;
        public System.Windows.Forms.Label ageLabel;
    }
}