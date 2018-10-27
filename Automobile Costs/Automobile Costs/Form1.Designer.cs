namespace Automobile_Costs
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
            this.loanAmtPromptLabel = new System.Windows.Forms.Label();
            this.insurancePromptLabel = new System.Windows.Forms.Label();
            this.gasPromptLabel = new System.Windows.Forms.Label();
            this.oilPromptLabel = new System.Windows.Forms.Label();
            this.tiresPromptLabel = new System.Windows.Forms.Label();
            this.maintenancePromptLabel = new System.Windows.Forms.Label();
            this.monthlyExpensesOutputDescription = new System.Windows.Forms.Label();
            this.monthlyExpensesLabel = new System.Windows.Forms.Label();
            this.yearlyExpensesPromptLabel = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.insuranceTextBox = new System.Windows.Forms.TextBox();
            this.gasTextBox = new System.Windows.Forms.TextBox();
            this.maintenanceTextBox = new System.Windows.Forms.TextBox();
            this.tiresTextBox = new System.Windows.Forms.TextBox();
            this.oilTextBox = new System.Windows.Forms.TextBox();
            this.yearlyExpensesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loanAmtPromptLabel
            // 
            this.loanAmtPromptLabel.AutoSize = true;
            this.loanAmtPromptLabel.Location = new System.Drawing.Point(30, 48);
            this.loanAmtPromptLabel.Name = "loanAmtPromptLabel";
            this.loanAmtPromptLabel.Size = new System.Drawing.Size(213, 17);
            this.loanAmtPromptLabel.TabIndex = 1;
            this.loanAmtPromptLabel.Text = "Cost of loan payment per month:";
            // 
            // insurancePromptLabel
            // 
            this.insurancePromptLabel.AutoSize = true;
            this.insurancePromptLabel.Location = new System.Drawing.Point(53, 93);
            this.insurancePromptLabel.Name = "insurancePromptLabel";
            this.insurancePromptLabel.Size = new System.Drawing.Size(190, 17);
            this.insurancePromptLabel.TabIndex = 2;
            this.insurancePromptLabel.Text = "Cost of insurance per month:";
            // 
            // gasPromptLabel
            // 
            this.gasPromptLabel.AutoSize = true;
            this.gasPromptLabel.Location = new System.Drawing.Point(92, 136);
            this.gasPromptLabel.Name = "gasPromptLabel";
            this.gasPromptLabel.Size = new System.Drawing.Size(151, 17);
            this.gasPromptLabel.TabIndex = 3;
            this.gasPromptLabel.Text = "Cost of gas per month:";
            // 
            // oilPromptLabel
            // 
            this.oilPromptLabel.AutoSize = true;
            this.oilPromptLabel.Location = new System.Drawing.Point(101, 184);
            this.oilPromptLabel.Name = "oilPromptLabel";
            this.oilPromptLabel.Size = new System.Drawing.Size(142, 17);
            this.oilPromptLabel.TabIndex = 4;
            this.oilPromptLabel.Text = "Cost of oil per month:";
            // 
            // tiresPromptLabel
            // 
            this.tiresPromptLabel.AutoSize = true;
            this.tiresPromptLabel.Location = new System.Drawing.Point(12, 231);
            this.tiresPromptLabel.Name = "tiresPromptLabel";
            this.tiresPromptLabel.Size = new System.Drawing.Size(231, 17);
            this.tiresPromptLabel.TabIndex = 5;
            this.tiresPromptLabel.Text = "Cost of maintaining tires per month:";
            // 
            // maintenancePromptLabel
            // 
            this.maintenancePromptLabel.AutoSize = true;
            this.maintenancePromptLabel.Location = new System.Drawing.Point(34, 282);
            this.maintenancePromptLabel.Name = "maintenancePromptLabel";
            this.maintenancePromptLabel.Size = new System.Drawing.Size(209, 17);
            this.maintenancePromptLabel.TabIndex = 6;
            this.maintenancePromptLabel.Text = "Cost of maintenance per month:";
            // 
            // monthlyExpensesOutputDescription
            // 
            this.monthlyExpensesOutputDescription.AutoSize = true;
            this.monthlyExpensesOutputDescription.Location = new System.Drawing.Point(82, 338);
            this.monthlyExpensesOutputDescription.Name = "monthlyExpensesOutputDescription";
            this.monthlyExpensesOutputDescription.Size = new System.Drawing.Size(161, 17);
            this.monthlyExpensesOutputDescription.TabIndex = 7;
            this.monthlyExpensesOutputDescription.Text = "Total monthly expenses:";
            // 
            // monthlyExpensesLabel
            // 
            this.monthlyExpensesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyExpensesLabel.Location = new System.Drawing.Point(261, 332);
            this.monthlyExpensesLabel.Name = "monthlyExpensesLabel";
            this.monthlyExpensesLabel.Size = new System.Drawing.Size(100, 22);
            this.monthlyExpensesLabel.TabIndex = 8;
            this.monthlyExpensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearlyExpensesPromptLabel
            // 
            this.yearlyExpensesPromptLabel.AutoSize = true;
            this.yearlyExpensesPromptLabel.Location = new System.Drawing.Point(91, 397);
            this.yearlyExpensesPromptLabel.Name = "yearlyExpensesPromptLabel";
            this.yearlyExpensesPromptLabel.Size = new System.Drawing.Size(150, 17);
            this.yearlyExpensesPromptLabel.TabIndex = 8;
            this.yearlyExpensesPromptLabel.Text = "Total yearly expenses:";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(261, 45);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(100, 22);
            this.loanTextBox.TabIndex = 1;
            this.loanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insuranceTextBox
            // 
            this.insuranceTextBox.Location = new System.Drawing.Point(261, 90);
            this.insuranceTextBox.Name = "insuranceTextBox";
            this.insuranceTextBox.Size = new System.Drawing.Size(100, 22);
            this.insuranceTextBox.TabIndex = 2;
            this.insuranceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gasTextBox
            // 
            this.gasTextBox.Location = new System.Drawing.Point(261, 133);
            this.gasTextBox.Name = "gasTextBox";
            this.gasTextBox.Size = new System.Drawing.Size(100, 22);
            this.gasTextBox.TabIndex = 3;
            this.gasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maintenanceTextBox
            // 
            this.maintenanceTextBox.Location = new System.Drawing.Point(261, 279);
            this.maintenanceTextBox.Name = "maintenanceTextBox";
            this.maintenanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.maintenanceTextBox.TabIndex = 6;
            this.maintenanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tiresTextBox
            // 
            this.tiresTextBox.Location = new System.Drawing.Point(261, 231);
            this.tiresTextBox.Name = "tiresTextBox";
            this.tiresTextBox.Size = new System.Drawing.Size(100, 22);
            this.tiresTextBox.TabIndex = 5;
            this.tiresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oilTextBox
            // 
            this.oilTextBox.Location = new System.Drawing.Point(261, 181);
            this.oilTextBox.Name = "oilTextBox";
            this.oilTextBox.Size = new System.Drawing.Size(100, 22);
            this.oilTextBox.TabIndex = 4;
            this.oilTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearlyExpensesLabel
            // 
            this.yearlyExpensesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearlyExpensesLabel.Location = new System.Drawing.Point(261, 394);
            this.yearlyExpensesLabel.Name = "yearlyExpensesLabel";
            this.yearlyExpensesLabel.Size = new System.Drawing.Size(100, 22);
            this.yearlyExpensesLabel.TabIndex = 9;
            this.yearlyExpensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(132, 462);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(111, 43);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(132, 530);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 44);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 660);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yearlyExpensesLabel);
            this.Controls.Add(this.oilTextBox);
            this.Controls.Add(this.tiresTextBox);
            this.Controls.Add(this.maintenanceTextBox);
            this.Controls.Add(this.gasTextBox);
            this.Controls.Add(this.insuranceTextBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.yearlyExpensesPromptLabel);
            this.Controls.Add(this.monthlyExpensesLabel);
            this.Controls.Add(this.monthlyExpensesOutputDescription);
            this.Controls.Add(this.maintenancePromptLabel);
            this.Controls.Add(this.tiresPromptLabel);
            this.Controls.Add(this.oilPromptLabel);
            this.Controls.Add(this.gasPromptLabel);
            this.Controls.Add(this.insurancePromptLabel);
            this.Controls.Add(this.loanAmtPromptLabel);
            this.Name = "Form1";
            this.Text = "Automobile Costs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanAmtPromptLabel;
        private System.Windows.Forms.Label insurancePromptLabel;
        private System.Windows.Forms.Label gasPromptLabel;
        private System.Windows.Forms.Label oilPromptLabel;
        private System.Windows.Forms.Label tiresPromptLabel;
        private System.Windows.Forms.Label maintenancePromptLabel;
        private System.Windows.Forms.Label monthlyExpensesOutputDescription;
        private System.Windows.Forms.Label monthlyExpensesLabel;
        private System.Windows.Forms.Label yearlyExpensesPromptLabel;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.TextBox insuranceTextBox;
        private System.Windows.Forms.TextBox gasTextBox;
        private System.Windows.Forms.TextBox maintenanceTextBox;
        private System.Windows.Forms.TextBox tiresTextBox;
        private System.Windows.Forms.TextBox oilTextBox;
        private System.Windows.Forms.Label yearlyExpensesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

