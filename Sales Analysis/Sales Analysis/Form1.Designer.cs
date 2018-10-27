namespace Sales_Analysis
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.salesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.avgDescriptionLabel = new System.Windows.Forms.Label();
            this.largestDescriptionLabel = new System.Windows.Forms.Label();
            this.smallestDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(115, 229);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.outputDescriptionLabel.TabIndex = 0;
            this.outputDescriptionLabel.Text = "Total Sales:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(243, 218);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(133, 28);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(118, 285);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 63);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Read Sales && Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 285);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 63);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.ItemHeight = 16;
            this.salesListBox.Location = new System.Drawing.Point(118, 38);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(258, 132);
            this.salesListBox.TabIndex = 4;
            // 
            // salesOutputDescriptionLabel
            // 
            this.salesOutputDescriptionLabel.AutoSize = true;
            this.salesOutputDescriptionLabel.Location = new System.Drawing.Point(224, 9);
            this.salesOutputDescriptionLabel.Name = "salesOutputDescriptionLabel";
            this.salesOutputDescriptionLabel.Size = new System.Drawing.Size(43, 17);
            this.salesOutputDescriptionLabel.TabIndex = 5;
            this.salesOutputDescriptionLabel.Text = "Sales";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(431, 101);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(133, 28);
            this.averageLabel.TabIndex = 9;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largestLabel
            // 
            this.largestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largestLabel.Location = new System.Drawing.Point(431, 164);
            this.largestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(133, 28);
            this.largestLabel.TabIndex = 10;
            this.largestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallestLabel
            // 
            this.smallestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallestLabel.Location = new System.Drawing.Point(431, 229);
            this.smallestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(133, 28);
            this.smallestLabel.TabIndex = 11;
            this.smallestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgDescriptionLabel
            // 
            this.avgDescriptionLabel.AutoSize = true;
            this.avgDescriptionLabel.Location = new System.Drawing.Point(469, 84);
            this.avgDescriptionLabel.Name = "avgDescriptionLabel";
            this.avgDescriptionLabel.Size = new System.Drawing.Size(61, 17);
            this.avgDescriptionLabel.TabIndex = 12;
            this.avgDescriptionLabel.Text = "Average";
            // 
            // largestDescriptionLabel
            // 
            this.largestDescriptionLabel.AutoSize = true;
            this.largestDescriptionLabel.Location = new System.Drawing.Point(469, 147);
            this.largestDescriptionLabel.Name = "largestDescriptionLabel";
            this.largestDescriptionLabel.Size = new System.Drawing.Size(56, 17);
            this.largestDescriptionLabel.TabIndex = 13;
            this.largestDescriptionLabel.Text = "Largest";
            // 
            // smallestDescriptionLabel
            // 
            this.smallestDescriptionLabel.AutoSize = true;
            this.smallestDescriptionLabel.Location = new System.Drawing.Point(469, 212);
            this.smallestDescriptionLabel.Name = "smallestDescriptionLabel";
            this.smallestDescriptionLabel.Size = new System.Drawing.Size(61, 17);
            this.smallestDescriptionLabel.TabIndex = 14;
            this.smallestDescriptionLabel.Text = "Smallest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 395);
            this.Controls.Add(this.smallestDescriptionLabel);
            this.Controls.Add(this.largestDescriptionLabel);
            this.Controls.Add(this.avgDescriptionLabel);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.largestLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.salesOutputDescriptionLabel);
            this.Controls.Add(this.salesListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label outputDescriptionLabel;
    private System.Windows.Forms.Label totalLabel;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.ListBox salesListBox;
    private System.Windows.Forms.Label salesOutputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label smallestLabel;
        private System.Windows.Forms.Label avgDescriptionLabel;
        private System.Windows.Forms.Label largestDescriptionLabel;
        private System.Windows.Forms.Label smallestDescriptionLabel;
    }
}

