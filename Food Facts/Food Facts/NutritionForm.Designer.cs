namespace Food_Facts
{
    partial class NutritionForm
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
            this.foodODLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.caloriesODLabel = new System.Windows.Forms.Label();
            this.fatGramsLabel = new System.Windows.Forms.Label();
            this.fatGramsODLabel = new System.Windows.Forms.Label();
            this.carbGramsLabel = new System.Windows.Forms.Label();
            this.carbGramsODLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodODLabel
            // 
            this.foodODLabel.AutoSize = true;
            this.foodODLabel.Location = new System.Drawing.Point(101, 48);
            this.foodODLabel.Name = "foodODLabel";
            this.foodODLabel.Size = new System.Drawing.Size(40, 17);
            this.foodODLabel.TabIndex = 0;
            this.foodODLabel.Text = "Food";
            // 
            // foodLabel
            // 
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Location = new System.Drawing.Point(181, 29);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(152, 36);
            this.foodLabel.TabIndex = 1;
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Location = new System.Drawing.Point(181, 88);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(152, 36);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesODLabel
            // 
            this.caloriesODLabel.AutoSize = true;
            this.caloriesODLabel.Location = new System.Drawing.Point(82, 107);
            this.caloriesODLabel.Name = "caloriesODLabel";
            this.caloriesODLabel.Size = new System.Drawing.Size(59, 17);
            this.caloriesODLabel.TabIndex = 2;
            this.caloriesODLabel.Text = "Calories";
            // 
            // fatGramsLabel
            // 
            this.fatGramsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatGramsLabel.Location = new System.Drawing.Point(181, 150);
            this.fatGramsLabel.Name = "fatGramsLabel";
            this.fatGramsLabel.Size = new System.Drawing.Size(152, 36);
            this.fatGramsLabel.TabIndex = 5;
            this.fatGramsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatGramsODLabel
            // 
            this.fatGramsODLabel.AutoSize = true;
            this.fatGramsODLabel.Location = new System.Drawing.Point(67, 169);
            this.fatGramsODLabel.Name = "fatGramsODLabel";
            this.fatGramsODLabel.Size = new System.Drawing.Size(74, 17);
            this.fatGramsODLabel.TabIndex = 4;
            this.fatGramsODLabel.Text = "Fat Grams";
            // 
            // carbGramsLabel
            // 
            this.carbGramsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbGramsLabel.Location = new System.Drawing.Point(181, 217);
            this.carbGramsLabel.Name = "carbGramsLabel";
            this.carbGramsLabel.Size = new System.Drawing.Size(152, 36);
            this.carbGramsLabel.TabIndex = 7;
            this.carbGramsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbGramsODLabel
            // 
            this.carbGramsODLabel.AutoSize = true;
            this.carbGramsODLabel.Location = new System.Drawing.Point(57, 236);
            this.carbGramsODLabel.Name = "carbGramsODLabel";
            this.carbGramsODLabel.Size = new System.Drawing.Size(84, 17);
            this.carbGramsODLabel.TabIndex = 6;
            this.carbGramsODLabel.Text = "Carb Grams";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(153, 288);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 42);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 342);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.carbGramsLabel);
            this.Controls.Add(this.carbGramsODLabel);
            this.Controls.Add(this.fatGramsLabel);
            this.Controls.Add(this.fatGramsODLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.caloriesODLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodODLabel);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodODLabel;
        private System.Windows.Forms.Label caloriesODLabel;
        private System.Windows.Forms.Label fatGramsODLabel;
        private System.Windows.Forms.Label carbGramsODLabel;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        public System.Windows.Forms.Label fatGramsLabel;
        public System.Windows.Forms.Label carbGramsLabel;
    }
}