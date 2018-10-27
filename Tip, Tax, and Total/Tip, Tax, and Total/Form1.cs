using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        const decimal TIP_PERCENTAGE = 0.15m;
        const decimal TAX_PERCENTAGE = 0.07m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice = decimal.Parse(mealPriceTextBox.Text);
            decimal tipAmount = originalPrice * TIP_PERCENTAGE;
            decimal taxAmount = originalPrice * TAX_PERCENTAGE;

            //Tax amount and tip amount are calculated from the original price separately.
            decimal totalPrice = originalPrice + tipAmount + taxAmount;

            tipLabel.Text = tipAmount.ToString("c");
            taxLabel.Text = taxAmount.ToString("c");
            totalLabel.Text = totalPrice.ToString("c");
        }
    }
}
