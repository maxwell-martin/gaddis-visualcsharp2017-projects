namespace C_and_F_Temperature_Converter
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.celsiusConvertButton = new System.Windows.Forms.Button();
            this.fahrenheitConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(234, 65);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(139, 17);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a temperature:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(399, 65);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 22);
            this.temperatureTextBox.TabIndex = 1;
            // 
            // celsiusConvertButton
            // 
            this.celsiusConvertButton.AutoSize = true;
            this.celsiusConvertButton.Location = new System.Drawing.Point(212, 175);
            this.celsiusConvertButton.Name = "celsiusConvertButton";
            this.celsiusConvertButton.Size = new System.Drawing.Size(132, 27);
            this.celsiusConvertButton.TabIndex = 2;
            this.celsiusConvertButton.Text = "Convert to Celsius";
            this.celsiusConvertButton.UseVisualStyleBackColor = true;
            this.celsiusConvertButton.Click += new System.EventHandler(this.celsiusConvertButton_Click);
            // 
            // fahrenheitConvertButton
            // 
            this.fahrenheitConvertButton.AutoSize = true;
            this.fahrenheitConvertButton.Location = new System.Drawing.Point(381, 175);
            this.fahrenheitConvertButton.Name = "fahrenheitConvertButton";
            this.fahrenheitConvertButton.Size = new System.Drawing.Size(155, 27);
            this.fahrenheitConvertButton.TabIndex = 3;
            this.fahrenheitConvertButton.Text = "Convert to Fahrenheit";
            this.fahrenheitConvertButton.UseVisualStyleBackColor = true;
            this.fahrenheitConvertButton.Click += new System.EventHandler(this.fahrenheitConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 513);
            this.Controls.Add(this.fahrenheitConvertButton);
            this.Controls.Add(this.celsiusConvertButton);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Button celsiusConvertButton;
        private System.Windows.Forms.Button fahrenheitConvertButton;
    }
}

