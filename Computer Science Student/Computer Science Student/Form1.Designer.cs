namespace Computer_Science_Student
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
            this.exitButton = new System.Windows.Forms.Button();
            this.getHoursButton = new System.Windows.Forms.Button();
            this.studentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.requiredHoursLabel = new System.Windows.Forms.Label();
            this.softwareEngineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.outputRequiredHoursLabel = new System.Windows.Forms.Label();
            this.inputAcademicTrackLabel = new System.Windows.Forms.Label();
            this.inputIDlLabel = new System.Windows.Forms.Label();
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.studentDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 250);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 58);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getHoursButton
            // 
            this.getHoursButton.Location = new System.Drawing.Point(92, 250);
            this.getHoursButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getHoursButton.Name = "getHoursButton";
            this.getHoursButton.Size = new System.Drawing.Size(113, 58);
            this.getHoursButton.TabIndex = 9;
            this.getHoursButton.Text = "Get Required Hours";
            this.getHoursButton.UseVisualStyleBackColor = true;
            this.getHoursButton.Click += new System.EventHandler(this.getHoursButton_Click);
            // 
            // studentDataGroupBox
            // 
            this.studentDataGroupBox.Controls.Add(this.requiredHoursLabel);
            this.studentDataGroupBox.Controls.Add(this.softwareEngineeringRadioButton);
            this.studentDataGroupBox.Controls.Add(this.infoSystemsRadioButton);
            this.studentDataGroupBox.Controls.Add(this.idTextBox);
            this.studentDataGroupBox.Controls.Add(this.nameTextBox);
            this.studentDataGroupBox.Controls.Add(this.outputRequiredHoursLabel);
            this.studentDataGroupBox.Controls.Add(this.inputAcademicTrackLabel);
            this.studentDataGroupBox.Controls.Add(this.inputIDlLabel);
            this.studentDataGroupBox.Controls.Add(this.inputNameLabel);
            this.studentDataGroupBox.Location = new System.Drawing.Point(45, 15);
            this.studentDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentDataGroupBox.Name = "studentDataGroupBox";
            this.studentDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentDataGroupBox.Size = new System.Drawing.Size(328, 228);
            this.studentDataGroupBox.TabIndex = 8;
            this.studentDataGroupBox.TabStop = false;
            this.studentDataGroupBox.Text = "Student Data";
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLabel.Location = new System.Drawing.Point(145, 174);
            this.requiredHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(162, 28);
            this.requiredHoursLabel.TabIndex = 9;
            this.requiredHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // softwareEngineeringRadioButton
            // 
            this.softwareEngineeringRadioButton.AutoSize = true;
            this.softwareEngineeringRadioButton.Location = new System.Drawing.Point(149, 129);
            this.softwareEngineeringRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.softwareEngineeringRadioButton.Name = "softwareEngineeringRadioButton";
            this.softwareEngineeringRadioButton.Size = new System.Drawing.Size(164, 21);
            this.softwareEngineeringRadioButton.TabIndex = 8;
            this.softwareEngineeringRadioButton.TabStop = true;
            this.softwareEngineeringRadioButton.Text = "Software Engineering";
            this.softwareEngineeringRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(149, 101);
            this.infoSystemsRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(156, 21);
            this.infoSystemsRadioButton.TabIndex = 7;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Information Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(149, 59);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(157, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(149, 27);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // outputRequiredHoursLabel
            // 
            this.outputRequiredHoursLabel.AutoSize = true;
            this.outputRequiredHoursLabel.Location = new System.Drawing.Point(20, 178);
            this.outputRequiredHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputRequiredHoursLabel.Name = "outputRequiredHoursLabel";
            this.outputRequiredHoursLabel.Size = new System.Drawing.Size(112, 17);
            this.outputRequiredHoursLabel.TabIndex = 3;
            this.outputRequiredHoursLabel.Text = "Required Hours:";
            // 
            // inputAcademicTrackLabel
            // 
            this.inputAcademicTrackLabel.AutoSize = true;
            this.inputAcademicTrackLabel.Location = new System.Drawing.Point(15, 118);
            this.inputAcademicTrackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputAcademicTrackLabel.Name = "inputAcademicTrackLabel";
            this.inputAcademicTrackLabel.Size = new System.Drawing.Size(113, 17);
            this.inputAcademicTrackLabel.TabIndex = 2;
            this.inputAcademicTrackLabel.Text = "Academic Track:";
            // 
            // inputIDlLabel
            // 
            this.inputIDlLabel.AutoSize = true;
            this.inputIDlLabel.Location = new System.Drawing.Point(51, 63);
            this.inputIDlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputIDlLabel.Name = "inputIDlLabel";
            this.inputIDlLabel.Size = new System.Drawing.Size(79, 17);
            this.inputIDlLabel.TabIndex = 1;
            this.inputIDlLabel.Text = "ID Number:";
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(81, 31);
            this.inputNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(49, 17);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 322);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getHoursButton);
            this.Controls.Add(this.studentDataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.studentDataGroupBox.ResumeLayout(false);
            this.studentDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getHoursButton;
        private System.Windows.Forms.GroupBox studentDataGroupBox;
        private System.Windows.Forms.Label requiredHoursLabel;
        private System.Windows.Forms.RadioButton softwareEngineeringRadioButton;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label outputRequiredHoursLabel;
        private System.Windows.Forms.Label inputAcademicTrackLabel;
        private System.Windows.Forms.Label inputIDlLabel;
        private System.Windows.Forms.Label inputNameLabel;
    }
}

