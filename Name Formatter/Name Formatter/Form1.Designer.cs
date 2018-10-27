namespace Name_Formatter
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
            this.firstNamePromptLabel = new System.Windows.Forms.Label();
            this.middleNamePromptLabel = new System.Windows.Forms.Label();
            this.lastNamePromptLabel = new System.Windows.Forms.Label();
            this.titlePromptLabel = new System.Windows.Forms.Label();
            this.formattedNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.format1 = new System.Windows.Forms.Button();
            this.format2 = new System.Windows.Forms.Button();
            this.format3 = new System.Windows.Forms.Button();
            this.format4 = new System.Windows.Forms.Button();
            this.format5 = new System.Windows.Forms.Button();
            this.format6 = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNamePromptLabel
            // 
            this.firstNamePromptLabel.AutoSize = true;
            this.firstNamePromptLabel.Location = new System.Drawing.Point(304, 63);
            this.firstNamePromptLabel.Name = "firstNamePromptLabel";
            this.firstNamePromptLabel.Size = new System.Drawing.Size(144, 17);
            this.firstNamePromptLabel.TabIndex = 0;
            this.firstNamePromptLabel.Text = "Enter your first name:";
            // 
            // middleNamePromptLabel
            // 
            this.middleNamePromptLabel.AutoSize = true;
            this.middleNamePromptLabel.Location = new System.Drawing.Point(304, 132);
            this.middleNamePromptLabel.Name = "middleNamePromptLabel";
            this.middleNamePromptLabel.Size = new System.Drawing.Size(162, 17);
            this.middleNamePromptLabel.TabIndex = 1;
            this.middleNamePromptLabel.Text = "Enter your middle name:";
            // 
            // lastNamePromptLabel
            // 
            this.lastNamePromptLabel.AutoSize = true;
            this.lastNamePromptLabel.Location = new System.Drawing.Point(305, 201);
            this.lastNamePromptLabel.Name = "lastNamePromptLabel";
            this.lastNamePromptLabel.Size = new System.Drawing.Size(143, 17);
            this.lastNamePromptLabel.TabIndex = 2;
            this.lastNamePromptLabel.Text = "Enter your last name:";
            // 
            // titlePromptLabel
            // 
            this.titlePromptLabel.AutoSize = true;
            this.titlePromptLabel.Location = new System.Drawing.Point(304, 271);
            this.titlePromptLabel.Name = "titlePromptLabel";
            this.titlePromptLabel.Size = new System.Drawing.Size(297, 17);
            this.titlePromptLabel.TabIndex = 3;
            this.titlePromptLabel.Text = "Enter preferred title (Mr., Mrs., Ms., Miss, Dr.):";
            // 
            // formattedNameLabel
            // 
            this.formattedNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formattedNameLabel.Location = new System.Drawing.Point(307, 349);
            this.formattedNameLabel.Name = "formattedNameLabel";
            this.formattedNameLabel.Size = new System.Drawing.Size(465, 23);
            this.formattedNameLabel.TabIndex = 4;
            this.formattedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(672, 58);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(208, 22);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(672, 127);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(208, 22);
            this.middleNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(672, 198);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(208, 22);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(672, 268);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(208, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // format1
            // 
            this.format1.AutoSize = true;
            this.format1.Location = new System.Drawing.Point(115, 438);
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(93, 27);
            this.format1.TabIndex = 9;
            this.format1.Text = "Format One";
            this.format1.UseVisualStyleBackColor = true;
            this.format1.Click += new System.EventHandler(this.format1_Click);
            // 
            // format2
            // 
            this.format2.AutoSize = true;
            this.format2.Location = new System.Drawing.Point(260, 438);
            this.format2.Name = "format2";
            this.format2.Size = new System.Drawing.Size(92, 27);
            this.format2.TabIndex = 10;
            this.format2.Text = "Format Two";
            this.format2.UseVisualStyleBackColor = true;
            this.format2.Click += new System.EventHandler(this.format2_Click);
            // 
            // format3
            // 
            this.format3.AutoSize = true;
            this.format3.Location = new System.Drawing.Point(407, 438);
            this.format3.Name = "format3";
            this.format3.Size = new System.Drawing.Size(104, 27);
            this.format3.TabIndex = 11;
            this.format3.Text = "Format Three";
            this.format3.UseVisualStyleBackColor = true;
            this.format3.Click += new System.EventHandler(this.format3_Click);
            // 
            // format4
            // 
            this.format4.AutoSize = true;
            this.format4.Location = new System.Drawing.Point(574, 438);
            this.format4.Name = "format4";
            this.format4.Size = new System.Drawing.Size(95, 27);
            this.format4.TabIndex = 12;
            this.format4.Text = "Format Four";
            this.format4.UseVisualStyleBackColor = true;
            this.format4.Click += new System.EventHandler(this.format4_Click);
            // 
            // format5
            // 
            this.format5.AutoSize = true;
            this.format5.Location = new System.Drawing.Point(728, 438);
            this.format5.Name = "format5";
            this.format5.Size = new System.Drawing.Size(92, 27);
            this.format5.TabIndex = 13;
            this.format5.Text = "Format Five";
            this.format5.UseVisualStyleBackColor = true;
            this.format5.Click += new System.EventHandler(this.format5_Click);
            // 
            // format6
            // 
            this.format6.AutoSize = true;
            this.format6.Location = new System.Drawing.Point(878, 438);
            this.format6.Name = "format6";
            this.format6.Size = new System.Drawing.Size(84, 27);
            this.format6.TabIndex = 14;
            this.format6.Text = "Format Six";
            this.format6.UseVisualStyleBackColor = true;
            this.format6.Click += new System.EventHandler(this.format6_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(168, 352);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(117, 17);
            this.outputDescriptionLabel.TabIndex = 15;
            this.outputDescriptionLabel.Text = "Formatted Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fill in the textboxes with the request information and click a format:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.format6);
            this.Controls.Add(this.format5);
            this.Controls.Add(this.format4);
            this.Controls.Add(this.format3);
            this.Controls.Add(this.format2);
            this.Controls.Add(this.format1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.formattedNameLabel);
            this.Controls.Add(this.titlePromptLabel);
            this.Controls.Add(this.lastNamePromptLabel);
            this.Controls.Add(this.middleNamePromptLabel);
            this.Controls.Add(this.firstNamePromptLabel);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePromptLabel;
        private System.Windows.Forms.Label middleNamePromptLabel;
        private System.Windows.Forms.Label lastNamePromptLabel;
        private System.Windows.Forms.Label titlePromptLabel;
        private System.Windows.Forms.Label formattedNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button format1;
        private System.Windows.Forms.Button format2;
        private System.Windows.Forms.Button format3;
        private System.Windows.Forms.Button format4;
        private System.Windows.Forms.Button format5;
        private System.Windows.Forms.Button format6;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label label1;
    }
}

