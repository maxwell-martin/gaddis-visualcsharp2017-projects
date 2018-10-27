namespace Workshop_Selector
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
            this.workshopGroupBox = new System.Windows.Forms.GroupBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pricingLabel = new System.Windows.Forms.Label();
            this.registrationOutputDescLabel = new System.Windows.Forms.Label();
            this.lodgingOutputDescLabel = new System.Windows.Forms.Label();
            this.totalOutputDescLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.workshopGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // workshopGroupBox
            // 
            this.workshopGroupBox.Controls.Add(this.workshopListBox);
            this.workshopGroupBox.Location = new System.Drawing.Point(80, 120);
            this.workshopGroupBox.Name = "workshopGroupBox";
            this.workshopGroupBox.Size = new System.Drawing.Size(267, 230);
            this.workshopGroupBox.TabIndex = 0;
            this.workshopGroupBox.TabStop = false;
            this.workshopGroupBox.Text = "Workshop";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(227, 49);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(513, 17);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Select a workshop and a location and then press calculate to see pricing details." +
    "";
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.locationListBox);
            this.locationGroupBox.Location = new System.Drawing.Point(385, 120);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(267, 230);
            this.locationGroupBox.TabIndex = 1;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // workshopListBox
            // 
            this.workshopListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 22;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(31, 35);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(204, 158);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 22;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(31, 33);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(204, 158);
            this.locationListBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(285, 389);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(142, 55);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pricingLabel
            // 
            this.pricingLabel.AutoSize = true;
            this.pricingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingLabel.Location = new System.Drawing.Point(793, 120);
            this.pricingLabel.Name = "pricingLabel";
            this.pricingLabel.Size = new System.Drawing.Size(51, 17);
            this.pricingLabel.TabIndex = 3;
            this.pricingLabel.Text = "Pricing";
            // 
            // registrationOutputDescLabel
            // 
            this.registrationOutputDescLabel.AutoSize = true;
            this.registrationOutputDescLabel.Location = new System.Drawing.Point(676, 178);
            this.registrationOutputDescLabel.Name = "registrationOutputDescLabel";
            this.registrationOutputDescLabel.Size = new System.Drawing.Size(88, 17);
            this.registrationOutputDescLabel.TabIndex = 4;
            this.registrationOutputDescLabel.Text = "Registration:";
            // 
            // lodgingOutputDescLabel
            // 
            this.lodgingOutputDescLabel.AutoSize = true;
            this.lodgingOutputDescLabel.Location = new System.Drawing.Point(676, 235);
            this.lodgingOutputDescLabel.Name = "lodgingOutputDescLabel";
            this.lodgingOutputDescLabel.Size = new System.Drawing.Size(63, 17);
            this.lodgingOutputDescLabel.TabIndex = 5;
            this.lodgingOutputDescLabel.Text = "Lodging:";
            // 
            // totalOutputDescLabel
            // 
            this.totalOutputDescLabel.AutoSize = true;
            this.totalOutputDescLabel.Location = new System.Drawing.Point(676, 297);
            this.totalOutputDescLabel.Name = "totalOutputDescLabel";
            this.totalOutputDescLabel.Size = new System.Drawing.Size(44, 17);
            this.totalOutputDescLabel.TabIndex = 6;
            this.totalOutputDescLabel.Text = "Total:";
            // 
            // registrationLabel
            // 
            this.registrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationLabel.Location = new System.Drawing.Point(770, 175);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(173, 23);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingLabel.Location = new System.Drawing.Point(770, 229);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(173, 23);
            this.lodgingLabel.TabIndex = 8;
            this.lodgingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(770, 291);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(173, 23);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 508);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.totalOutputDescLabel);
            this.Controls.Add(this.lodgingOutputDescLabel);
            this.Controls.Add(this.registrationOutputDescLabel);
            this.Controls.Add(this.pricingLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.workshopGroupBox);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.workshopGroupBox.ResumeLayout(false);
            this.locationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox workshopGroupBox;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label pricingLabel;
        private System.Windows.Forms.Label registrationOutputDescLabel;
        private System.Windows.Forms.Label lodgingOutputDescLabel;
        private System.Windows.Forms.Label totalOutputDescLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

