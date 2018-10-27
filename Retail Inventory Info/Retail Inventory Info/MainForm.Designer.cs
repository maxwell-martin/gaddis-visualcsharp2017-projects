namespace Retail_Inventory_Info
{
    partial class MainForm
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
            this.displayAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayAllButton
            // 
            this.displayAllButton.Location = new System.Drawing.Point(203, 130);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(259, 186);
            this.displayAllButton.TabIndex = 0;
            this.displayAllButton.Text = "Display All Data";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 465);
            this.Controls.Add(this.displayAllButton);
            this.Name = "MainForm";
            this.Text = "Retail Inventory Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayAllButton;
    }
}

