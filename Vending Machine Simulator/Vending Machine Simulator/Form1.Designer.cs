namespace Vending_Machine_Simulator
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.drink1Label = new System.Windows.Forms.Label();
            this.drink2Label = new System.Windows.Forms.Label();
            this.drink3Label = new System.Windows.Forms.Label();
            this.drink4Label = new System.Windows.Forms.Label();
            this.drink5Label = new System.Windows.Forms.Label();
            this.drink6Label = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.lemonLimePictureBox = new System.Windows.Forms.PictureBox();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.totalSalesOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.colaQuantityLabel = new System.Windows.Forms.Label();
            this.rootBeerQuantityLabel = new System.Windows.Forms.Label();
            this.lemonLimeQuantityLabel = new System.Windows.Forms.Label();
            this.colaQuantityOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.rootBeerQuantityOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.lemonLimeQuantityOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.grapeSodaQuantityOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.grapeSodaQuantityLabel = new System.Windows.Forms.Label();
            this.creamSodaQuantityOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.creamSodaQuantityLabel = new System.Windows.Forms.Label();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.rootBeerPriceLabel = new System.Windows.Forms.Label();
            this.lemonLimePriceLabel = new System.Windows.Forms.Label();
            this.grapeSodaPriceLabel = new System.Windows.Forms.Label();
            this.creamSodaPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(251, 35);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(96, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Select a Drink";
            // 
            // drink1Label
            // 
            this.drink1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink1Label.Location = new System.Drawing.Point(53, 71);
            this.drink1Label.Name = "drink1Label";
            this.drink1Label.Size = new System.Drawing.Size(242, 113);
            this.drink1Label.TabIndex = 1;
            // 
            // drink2Label
            // 
            this.drink2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink2Label.Location = new System.Drawing.Point(301, 71);
            this.drink2Label.Name = "drink2Label";
            this.drink2Label.Size = new System.Drawing.Size(242, 113);
            this.drink2Label.TabIndex = 2;
            // 
            // drink3Label
            // 
            this.drink3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink3Label.Location = new System.Drawing.Point(53, 202);
            this.drink3Label.Name = "drink3Label";
            this.drink3Label.Size = new System.Drawing.Size(242, 113);
            this.drink3Label.TabIndex = 3;
            // 
            // drink4Label
            // 
            this.drink4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink4Label.Location = new System.Drawing.Point(301, 202);
            this.drink4Label.Name = "drink4Label";
            this.drink4Label.Size = new System.Drawing.Size(242, 113);
            this.drink4Label.TabIndex = 4;
            // 
            // drink5Label
            // 
            this.drink5Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink5Label.Location = new System.Drawing.Point(53, 333);
            this.drink5Label.Name = "drink5Label";
            this.drink5Label.Size = new System.Drawing.Size(242, 113);
            this.drink5Label.TabIndex = 5;
            // 
            // drink6Label
            // 
            this.drink6Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drink6Label.Location = new System.Drawing.Point(301, 333);
            this.drink6Label.Name = "drink6Label";
            this.drink6Label.Size = new System.Drawing.Size(242, 113);
            this.drink6Label.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(254, 471);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Image = global::Vending_Machine_Simulator.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(68, 87);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(114, 80);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colaPictureBox.TabIndex = 8;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.Image = global::Vending_Machine_Simulator.Properties.Resources.RootBeer;
            this.rootBeerPictureBox.Location = new System.Drawing.Point(319, 87);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(114, 80);
            this.rootBeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rootBeerPictureBox.TabIndex = 9;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // lemonLimePictureBox
            // 
            this.lemonLimePictureBox.Image = global::Vending_Machine_Simulator.Properties.Resources.LemonLime;
            this.lemonLimePictureBox.Location = new System.Drawing.Point(68, 220);
            this.lemonLimePictureBox.Name = "lemonLimePictureBox";
            this.lemonLimePictureBox.Size = new System.Drawing.Size(114, 80);
            this.lemonLimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lemonLimePictureBox.TabIndex = 10;
            this.lemonLimePictureBox.TabStop = false;
            this.lemonLimePictureBox.Click += new System.EventHandler(this.lemonLimePictureBox_Click);
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.Image = global::Vending_Machine_Simulator.Properties.Resources.GrapeSoda;
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(319, 220);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(114, 80);
            this.grapeSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grapeSodaPictureBox.TabIndex = 11;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.grapeSodaPictureBox_Click);
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.Image = global::Vending_Machine_Simulator.Properties.Resources.CreamSoda;
            this.creamSodaPictureBox.Location = new System.Drawing.Point(68, 351);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(114, 80);
            this.creamSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creamSodaPictureBox.TabIndex = 12;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.creamSodaPictureBox_Click);
            // 
            // totalSalesOutputDescriptionLabel
            // 
            this.totalSalesOutputDescriptionLabel.AutoSize = true;
            this.totalSalesOutputDescriptionLabel.Location = new System.Drawing.Point(387, 351);
            this.totalSalesOutputDescriptionLabel.Name = "totalSalesOutputDescriptionLabel";
            this.totalSalesOutputDescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.totalSalesOutputDescriptionLabel.TabIndex = 13;
            this.totalSalesOutputDescriptionLabel.Text = "Total Sales";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesLabel.Location = new System.Drawing.Point(375, 377);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(107, 33);
            this.totalSalesLabel.TabIndex = 14;
            this.totalSalesLabel.Text = "$0.00";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaQuantityLabel
            // 
            this.colaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaQuantityLabel.Location = new System.Drawing.Point(201, 127);
            this.colaQuantityLabel.Name = "colaQuantityLabel";
            this.colaQuantityLabel.Size = new System.Drawing.Size(78, 40);
            this.colaQuantityLabel.TabIndex = 15;
            this.colaQuantityLabel.Text = "20";
            this.colaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerQuantityLabel
            // 
            this.rootBeerQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerQuantityLabel.Location = new System.Drawing.Point(452, 127);
            this.rootBeerQuantityLabel.Name = "rootBeerQuantityLabel";
            this.rootBeerQuantityLabel.Size = new System.Drawing.Size(78, 40);
            this.rootBeerQuantityLabel.TabIndex = 16;
            this.rootBeerQuantityLabel.Text = "20";
            this.rootBeerQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLimeQuantityLabel
            // 
            this.lemonLimeQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonLimeQuantityLabel.Location = new System.Drawing.Point(201, 260);
            this.lemonLimeQuantityLabel.Name = "lemonLimeQuantityLabel";
            this.lemonLimeQuantityLabel.Size = new System.Drawing.Size(78, 40);
            this.lemonLimeQuantityLabel.TabIndex = 17;
            this.lemonLimeQuantityLabel.Text = "20";
            this.lemonLimeQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaQuantityOutputDescriptionLabel
            // 
            this.colaQuantityOutputDescriptionLabel.AutoSize = true;
            this.colaQuantityOutputDescriptionLabel.Location = new System.Drawing.Point(199, 110);
            this.colaQuantityOutputDescriptionLabel.Name = "colaQuantityOutputDescriptionLabel";
            this.colaQuantityOutputDescriptionLabel.Size = new System.Drawing.Size(80, 17);
            this.colaQuantityOutputDescriptionLabel.TabIndex = 18;
            this.colaQuantityOutputDescriptionLabel.Text = "Drinks Left:";
            // 
            // rootBeerQuantityOutputDescriptionLabel
            // 
            this.rootBeerQuantityOutputDescriptionLabel.AutoSize = true;
            this.rootBeerQuantityOutputDescriptionLabel.Location = new System.Drawing.Point(450, 110);
            this.rootBeerQuantityOutputDescriptionLabel.Name = "rootBeerQuantityOutputDescriptionLabel";
            this.rootBeerQuantityOutputDescriptionLabel.Size = new System.Drawing.Size(80, 17);
            this.rootBeerQuantityOutputDescriptionLabel.TabIndex = 19;
            this.rootBeerQuantityOutputDescriptionLabel.Text = "Drinks Left:";
            // 
            // lemonLimeQuantityOutputDescriptionLabel
            // 
            this.lemonLimeQuantityOutputDescriptionLabel.AutoSize = true;
            this.lemonLimeQuantityOutputDescriptionLabel.Location = new System.Drawing.Point(199, 243);
            this.lemonLimeQuantityOutputDescriptionLabel.Name = "lemonLimeQuantityOutputDescriptionLabel";
            this.lemonLimeQuantityOutputDescriptionLabel.Size = new System.Drawing.Size(80, 17);
            this.lemonLimeQuantityOutputDescriptionLabel.TabIndex = 20;
            this.lemonLimeQuantityOutputDescriptionLabel.Text = "Drinks Left:";
            // 
            // grapeSodaQuantityOutputDescriptionLabel
            // 
            this.grapeSodaQuantityOutputDescriptionLabel.AutoSize = true;
            this.grapeSodaQuantityOutputDescriptionLabel.Location = new System.Drawing.Point(449, 243);
            this.grapeSodaQuantityOutputDescriptionLabel.Name = "grapeSodaQuantityOutputDescriptionLabel";
            this.grapeSodaQuantityOutputDescriptionLabel.Size = new System.Drawing.Size(80, 17);
            this.grapeSodaQuantityOutputDescriptionLabel.TabIndex = 21;
            this.grapeSodaQuantityOutputDescriptionLabel.Text = "Drinks Left:";
            // 
            // grapeSodaQuantityLabel
            // 
            this.grapeSodaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeSodaQuantityLabel.Location = new System.Drawing.Point(451, 260);
            this.grapeSodaQuantityLabel.Name = "grapeSodaQuantityLabel";
            this.grapeSodaQuantityLabel.Size = new System.Drawing.Size(78, 40);
            this.grapeSodaQuantityLabel.TabIndex = 22;
            this.grapeSodaQuantityLabel.Text = "20";
            this.grapeSodaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaQuantityOutputDescriptionLabel
            // 
            this.creamSodaQuantityOutputDescriptionLabel.AutoSize = true;
            this.creamSodaQuantityOutputDescriptionLabel.Location = new System.Drawing.Point(199, 374);
            this.creamSodaQuantityOutputDescriptionLabel.Name = "creamSodaQuantityOutputDescriptionLabel";
            this.creamSodaQuantityOutputDescriptionLabel.Size = new System.Drawing.Size(80, 17);
            this.creamSodaQuantityOutputDescriptionLabel.TabIndex = 23;
            this.creamSodaQuantityOutputDescriptionLabel.Text = "Drinks Left:";
            // 
            // creamSodaQuantityLabel
            // 
            this.creamSodaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamSodaQuantityLabel.Location = new System.Drawing.Point(201, 391);
            this.creamSodaQuantityLabel.Name = "creamSodaQuantityLabel";
            this.creamSodaQuantityLabel.Size = new System.Drawing.Size(78, 40);
            this.creamSodaQuantityLabel.TabIndex = 24;
            this.creamSodaQuantityLabel.Text = "20";
            this.creamSodaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.AutoSize = true;
            this.colaPriceLabel.Location = new System.Drawing.Point(216, 87);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(44, 17);
            this.colaPriceLabel.TabIndex = 25;
            this.colaPriceLabel.Text = "$1.00";
            // 
            // rootBeerPriceLabel
            // 
            this.rootBeerPriceLabel.AutoSize = true;
            this.rootBeerPriceLabel.Location = new System.Drawing.Point(467, 87);
            this.rootBeerPriceLabel.Name = "rootBeerPriceLabel";
            this.rootBeerPriceLabel.Size = new System.Drawing.Size(44, 17);
            this.rootBeerPriceLabel.TabIndex = 26;
            this.rootBeerPriceLabel.Text = "$1.00";
            // 
            // lemonLimePriceLabel
            // 
            this.lemonLimePriceLabel.AutoSize = true;
            this.lemonLimePriceLabel.Location = new System.Drawing.Point(216, 220);
            this.lemonLimePriceLabel.Name = "lemonLimePriceLabel";
            this.lemonLimePriceLabel.Size = new System.Drawing.Size(44, 17);
            this.lemonLimePriceLabel.TabIndex = 27;
            this.lemonLimePriceLabel.Text = "$1.00";
            // 
            // grapeSodaPriceLabel
            // 
            this.grapeSodaPriceLabel.AutoSize = true;
            this.grapeSodaPriceLabel.Location = new System.Drawing.Point(467, 220);
            this.grapeSodaPriceLabel.Name = "grapeSodaPriceLabel";
            this.grapeSodaPriceLabel.Size = new System.Drawing.Size(44, 17);
            this.grapeSodaPriceLabel.TabIndex = 28;
            this.grapeSodaPriceLabel.Text = "$1.50";
            // 
            // creamSodaPriceLabel
            // 
            this.creamSodaPriceLabel.AutoSize = true;
            this.creamSodaPriceLabel.Location = new System.Drawing.Point(216, 351);
            this.creamSodaPriceLabel.Name = "creamSodaPriceLabel";
            this.creamSodaPriceLabel.Size = new System.Drawing.Size(44, 17);
            this.creamSodaPriceLabel.TabIndex = 29;
            this.creamSodaPriceLabel.Text = "$1.50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 519);
            this.Controls.Add(this.creamSodaPriceLabel);
            this.Controls.Add(this.grapeSodaPriceLabel);
            this.Controls.Add(this.lemonLimePriceLabel);
            this.Controls.Add(this.rootBeerPriceLabel);
            this.Controls.Add(this.colaPriceLabel);
            this.Controls.Add(this.creamSodaQuantityLabel);
            this.Controls.Add(this.creamSodaQuantityOutputDescriptionLabel);
            this.Controls.Add(this.grapeSodaQuantityLabel);
            this.Controls.Add(this.grapeSodaQuantityOutputDescriptionLabel);
            this.Controls.Add(this.lemonLimeQuantityOutputDescriptionLabel);
            this.Controls.Add(this.rootBeerQuantityOutputDescriptionLabel);
            this.Controls.Add(this.colaQuantityOutputDescriptionLabel);
            this.Controls.Add(this.lemonLimeQuantityLabel);
            this.Controls.Add(this.rootBeerQuantityLabel);
            this.Controls.Add(this.colaQuantityLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.totalSalesOutputDescriptionLabel);
            this.Controls.Add(this.creamSodaPictureBox);
            this.Controls.Add(this.grapeSodaPictureBox);
            this.Controls.Add(this.lemonLimePictureBox);
            this.Controls.Add(this.rootBeerPictureBox);
            this.Controls.Add(this.colaPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.drink6Label);
            this.Controls.Add(this.drink5Label);
            this.Controls.Add(this.drink4Label);
            this.Controls.Add(this.drink3Label);
            this.Controls.Add(this.drink2Label);
            this.Controls.Add(this.drink1Label);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Vending Machine Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label drink1Label;
        private System.Windows.Forms.Label drink2Label;
        private System.Windows.Forms.Label drink3Label;
        private System.Windows.Forms.Label drink4Label;
        private System.Windows.Forms.Label drink5Label;
        private System.Windows.Forms.Label drink6Label;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.PictureBox lemonLimePictureBox;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.Label totalSalesOutputDescriptionLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label colaQuantityLabel;
        private System.Windows.Forms.Label rootBeerQuantityLabel;
        private System.Windows.Forms.Label lemonLimeQuantityLabel;
        private System.Windows.Forms.Label colaQuantityOutputDescriptionLabel;
        private System.Windows.Forms.Label rootBeerQuantityOutputDescriptionLabel;
        private System.Windows.Forms.Label lemonLimeQuantityOutputDescriptionLabel;
        private System.Windows.Forms.Label grapeSodaQuantityOutputDescriptionLabel;
        private System.Windows.Forms.Label grapeSodaQuantityLabel;
        private System.Windows.Forms.Label creamSodaQuantityOutputDescriptionLabel;
        private System.Windows.Forms.Label creamSodaQuantityLabel;
        private System.Windows.Forms.Label colaPriceLabel;
        private System.Windows.Forms.Label rootBeerPriceLabel;
        private System.Windows.Forms.Label lemonLimePriceLabel;
        private System.Windows.Forms.Label grapeSodaPriceLabel;
        private System.Windows.Forms.Label creamSodaPriceLabel;
    }
}

