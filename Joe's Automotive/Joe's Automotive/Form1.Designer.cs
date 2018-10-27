namespace Joe_s_Automotive
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.partsAndLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.partsPromptLabel = new System.Windows.Forms.Label();
            this.laborPromptLabel = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.serviceAndLaborOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.partsOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.taxOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsAndLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(31, 37);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(234, 100);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(271, 37);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(239, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(31, 163);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(234, 170);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // partsAndLaborGroupBox
            // 
            this.partsAndLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.laborPromptLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.partsPromptLabel);
            this.partsAndLaborGroupBox.Location = new System.Drawing.Point(271, 163);
            this.partsAndLaborGroupBox.Name = "partsAndLaborGroupBox";
            this.partsAndLaborGroupBox.Size = new System.Drawing.Size(239, 170);
            this.partsAndLaborGroupBox.TabIndex = 3;
            this.partsAndLaborGroupBox.TabStop = false;
            this.partsAndLaborGroupBox.Text = "Parts and Labor";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalFeesLabel);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partsLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborLabel);
            this.summaryGroupBox.Controls.Add(this.totalOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.taxOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborOutputDescriptionLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(31, 339);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(479, 213);
            this.summaryGroupBox.TabIndex = 1;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 578);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 43);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(216, 578);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 43);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(393, 578);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 43);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(15, 32);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(158, 21);
            this.oilChangeCheckBox.TabIndex = 5;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(15, 59);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(143, 21);
            this.lubeJobCheckBox.TabIndex = 6;
            this.lubeJobCheckBox.Text = "Lube job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(17, 32);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(180, 21);
            this.radiatorFlushCheckBox.TabIndex = 5;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(17, 59);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(210, 21);
            this.transmissionFlushCheckBox.TabIndex = 6;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(15, 40);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(152, 21);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(15, 79);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(195, 21);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(15, 121);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(170, 21);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsPromptLabel
            // 
            this.partsPromptLabel.AutoSize = true;
            this.partsPromptLabel.Location = new System.Drawing.Point(58, 59);
            this.partsPromptLabel.Name = "partsPromptLabel";
            this.partsPromptLabel.Size = new System.Drawing.Size(41, 17);
            this.partsPromptLabel.TabIndex = 0;
            this.partsPromptLabel.Text = "Parts";
            // 
            // laborPromptLabel
            // 
            this.laborPromptLabel.AutoSize = true;
            this.laborPromptLabel.Location = new System.Drawing.Point(32, 97);
            this.laborPromptLabel.Name = "laborPromptLabel";
            this.laborPromptLabel.Size = new System.Drawing.Size(67, 17);
            this.laborPromptLabel.TabIndex = 1;
            this.laborPromptLabel.Text = "Labor ($)";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(122, 54);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(75, 22);
            this.partsTextBox.TabIndex = 5;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(122, 92);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(75, 22);
            this.laborTextBox.TabIndex = 6;
            // 
            // serviceAndLaborOutputDescriptionLabel
            // 
            this.serviceAndLaborOutputDescriptionLabel.AutoSize = true;
            this.serviceAndLaborOutputDescriptionLabel.Location = new System.Drawing.Point(43, 48);
            this.serviceAndLaborOutputDescriptionLabel.Name = "serviceAndLaborOutputDescriptionLabel";
            this.serviceAndLaborOutputDescriptionLabel.Size = new System.Drawing.Size(124, 17);
            this.serviceAndLaborOutputDescriptionLabel.TabIndex = 0;
            this.serviceAndLaborOutputDescriptionLabel.Text = "Service and Labor";
            // 
            // partsOutputDescriptionLabel
            // 
            this.partsOutputDescriptionLabel.AutoSize = true;
            this.partsOutputDescriptionLabel.Location = new System.Drawing.Point(126, 85);
            this.partsOutputDescriptionLabel.Name = "partsOutputDescriptionLabel";
            this.partsOutputDescriptionLabel.Size = new System.Drawing.Size(41, 17);
            this.partsOutputDescriptionLabel.TabIndex = 1;
            this.partsOutputDescriptionLabel.Text = "Parts";
            // 
            // taxOutputDescriptionLabel
            // 
            this.taxOutputDescriptionLabel.AutoSize = true;
            this.taxOutputDescriptionLabel.Location = new System.Drawing.Point(76, 122);
            this.taxOutputDescriptionLabel.Name = "taxOutputDescriptionLabel";
            this.taxOutputDescriptionLabel.Size = new System.Drawing.Size(97, 17);
            this.taxOutputDescriptionLabel.TabIndex = 2;
            this.taxOutputDescriptionLabel.Text = "Tax (on parts)";
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(92, 166);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(75, 17);
            this.totalOutputDescriptionLabel.TabIndex = 3;
            this.totalOutputDescriptionLabel.Text = "Total Fees";
            // 
            // serviceAndLaborLabel
            // 
            this.serviceAndLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(185, 37);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(157, 28);
            this.serviceAndLaborLabel.TabIndex = 4;
            this.serviceAndLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsLabel
            // 
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsLabel.Location = new System.Drawing.Point(185, 74);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(157, 28);
            this.partsLabel.TabIndex = 5;
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(185, 111);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(157, 28);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesLabel.Location = new System.Drawing.Point(185, 155);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(157, 28);
            this.totalFeesLabel.TabIndex = 7;
            this.totalFeesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 633);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsAndLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsAndLaborGroupBox.ResumeLayout(false);
            this.partsAndLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsAndLaborGroupBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborPromptLabel;
        private System.Windows.Forms.Label partsPromptLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.Label taxOutputDescriptionLabel;
        private System.Windows.Forms.Label partsOutputDescriptionLabel;
        private System.Windows.Forms.Label serviceAndLaborOutputDescriptionLabel;
    }
}

