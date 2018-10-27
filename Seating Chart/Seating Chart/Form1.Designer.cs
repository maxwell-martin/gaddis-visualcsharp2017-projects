namespace Seating_Chart
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
            this.airplanePictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.seatPriceDescriptionLabel = new System.Windows.Forms.Label();
            this.colPromptLabel = new System.Windows.Forms.Label();
            this.rowPromptLabel = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayPriceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airplanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // airplanePictureBox
            // 
            this.airplanePictureBox.Image = global::Seating_Chart.Properties.Resources.Airplane;
            this.airplanePictureBox.Location = new System.Drawing.Point(0, 0);
            this.airplanePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.airplanePictureBox.Name = "airplanePictureBox";
            this.airplanePictureBox.Size = new System.Drawing.Size(576, 665);
            this.airplanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplanePictureBox.TabIndex = 0;
            this.airplanePictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(447, 32);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(101, 28);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seatPriceDescriptionLabel
            // 
            this.seatPriceDescriptionLabel.AutoSize = true;
            this.seatPriceDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.seatPriceDescriptionLabel.Location = new System.Drawing.Point(364, 38);
            this.seatPriceDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seatPriceDescriptionLabel.Name = "seatPriceDescriptionLabel";
            this.seatPriceDescriptionLabel.Size = new System.Drawing.Size(73, 17);
            this.seatPriceDescriptionLabel.TabIndex = 20;
            this.seatPriceDescriptionLabel.Text = "Seat Price";
            // 
            // colPromptLabel
            // 
            this.colPromptLabel.AutoSize = true;
            this.colPromptLabel.BackColor = System.Drawing.Color.White;
            this.colPromptLabel.Location = new System.Drawing.Point(9, 59);
            this.colPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colPromptLabel.Name = "colPromptLabel";
            this.colPromptLabel.Size = new System.Drawing.Size(105, 17);
            this.colPromptLabel.TabIndex = 19;
            this.colPromptLabel.Text = "Enter a Column";
            // 
            // rowPromptLabel
            // 
            this.rowPromptLabel.AutoSize = true;
            this.rowPromptLabel.BackColor = System.Drawing.Color.White;
            this.rowPromptLabel.Location = new System.Drawing.Point(27, 28);
            this.rowPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rowPromptLabel.Name = "rowPromptLabel";
            this.rowPromptLabel.Size = new System.Drawing.Size(85, 17);
            this.rowPromptLabel.TabIndex = 18;
            this.rowPromptLabel.Text = "Enter a Row";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(123, 55);
            this.txtCol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(84, 22);
            this.txtCol.TabIndex = 17;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(123, 23);
            this.txtRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(84, 22);
            this.txtRow.TabIndex = 16;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(293, 682);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 47);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayPriceButton
            // 
            this.displayPriceButton.Location = new System.Drawing.Point(185, 682);
            this.displayPriceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayPriceButton.Name = "displayPriceButton";
            this.displayPriceButton.Size = new System.Drawing.Size(100, 47);
            this.displayPriceButton.TabIndex = 22;
            this.displayPriceButton.Text = "Display Price";
            this.displayPriceButton.UseVisualStyleBackColor = true;
            this.displayPriceButton.Click += new System.EventHandler(this.displayPriceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 743);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayPriceButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.seatPriceDescriptionLabel);
            this.Controls.Add(this.colPromptLabel);
            this.Controls.Add(this.rowPromptLabel);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.airplanePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Seating Chart";
            ((System.ComponentModel.ISupportInitialize)(this.airplanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox airplanePictureBox;
        internal System.Windows.Forms.Label priceLabel;
        internal System.Windows.Forms.Label seatPriceDescriptionLabel;
        internal System.Windows.Forms.Label colPromptLabel;
        internal System.Windows.Forms.Label rowPromptLabel;
        internal System.Windows.Forms.TextBox txtCol;
        internal System.Windows.Forms.TextBox txtRow;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button displayPriceButton;
    }
}

