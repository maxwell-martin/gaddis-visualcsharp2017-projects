using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice = decimal.Parse(originalPriceTextBox.Text);
            decimal discountPercentage = decimal.Parse(discountPercentageTextBox.Text) / 100;
            decimal discountAmount = originalPrice * discountPercentage;
            decimal salePrice = originalPrice - discountAmount;

            salePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
