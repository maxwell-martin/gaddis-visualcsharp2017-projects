using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal retailPrice;

        private decimal RoundToTwoDecimalPlaces(decimal number)
        {
            number = Math.Round(number, 2);

            return number;
        }

        private bool IsInputValid(ref decimal wholesaleCost, ref decimal markupPercentage)
        {
            bool isValid = false;

            if (decimal.TryParse(wholesaleCostTextBox.Text, out wholesaleCost) && wholesaleCost >= 0m)
            {
                if (decimal.TryParse(markupTextBox.Text, out markupPercentage) && markupPercentage >= 0m)
                {

                    wholesaleCost = RoundToTwoDecimalPlaces(wholesaleCost);
                    markupPercentage = RoundToTwoDecimalPlaces(markupPercentage);

                    wholesaleCostTextBox.Text = wholesaleCost.ToString();
                    markupTextBox.Text = markupPercentage.ToString();

                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Markup percentage is invalid.");
                    markupTextBox.Clear();
                    markupTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Wholesale cost is invalid.");
                wholesaleCostTextBox.Clear();
                wholesaleCostTextBox.Focus();
            }

            return isValid;
        }

        private decimal CalculateRetail(decimal cost, decimal percentage)
        {
            decimal markupAmt;

            markupAmt = cost * (percentage / 100m);
            retailPrice = cost + markupAmt;

            return retailPrice;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal wholesaleCost = 0m, markupPercentage = 0m;

            if (IsInputValid(ref wholesaleCost, ref markupPercentage))
            {
                retailPrice = CalculateRetail(wholesaleCost, markupPercentage);

                retailPriceLabel.Text = retailPrice.ToString("c");
            }
            
        }
    }
}
