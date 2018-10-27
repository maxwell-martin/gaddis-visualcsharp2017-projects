namespace Pet_Information
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
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typePromptLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.agePromptLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.petsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(94, 59);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(74, 17);
            this.namePromptLabel.TabIndex = 0;
            this.namePromptLabel.Text = "Pet Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(186, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(186, 121);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 3;
            // 
            // typePromptLabel
            // 
            this.typePromptLabel.AutoSize = true;
            this.typePromptLabel.Location = new System.Drawing.Point(94, 126);
            this.typePromptLabel.Name = "typePromptLabel";
            this.typePromptLabel.Size = new System.Drawing.Size(69, 17);
            this.typePromptLabel.TabIndex = 2;
            this.typePromptLabel.Text = "Pet Type:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(186, 201);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 5;
            // 
            // agePromptLabel
            // 
            this.agePromptLabel.AutoSize = true;
            this.agePromptLabel.Location = new System.Drawing.Point(94, 206);
            this.agePromptLabel.Name = "agePromptLabel";
            this.agePromptLabel.Size = new System.Drawing.Size(62, 17);
            this.agePromptLabel.TabIndex = 4;
            this.agePromptLabel.Text = "Pet Age:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(138, 285);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 47);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // petsListBox
            // 
            this.petsListBox.FormattingEnabled = true;
            this.petsListBox.ItemHeight = 16;
            this.petsListBox.Location = new System.Drawing.Point(353, 96);
            this.petsListBox.Name = "petsListBox";
            this.petsListBox.Size = new System.Drawing.Size(311, 180);
            this.petsListBox.TabIndex = 7;
            this.petsListBox.SelectedIndexChanged += new System.EventHandler(this.petsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 409);
            this.Controls.Add(this.petsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.agePromptLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.typePromptLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "MainForm";
            this.Text = "Pet Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typePromptLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label agePromptLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox petsListBox;
    }
}

