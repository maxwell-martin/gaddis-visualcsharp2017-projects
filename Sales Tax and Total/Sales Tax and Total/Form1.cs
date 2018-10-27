using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        const double STATE_TAX_PERCENT = 0.04;
        const double COUNTY_TAX_PERCENT = 0.02;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double originalItemPrice = double.Parse(itemPriceTextBox.Text);
                double stateSalesTax = originalItemPrice * STATE_TAX_PERCENT;
                double countySalesTax = originalItemPrice * COUNTY_TAX_PERCENT;
                double totalSalesTax = stateSalesTax + countySalesTax;
                double totalCost = originalItemPrice + totalSalesTax;

                itemLabel.Text = originalItemPrice.ToString("c");
                stateSalesTaxLabel.Text = stateSalesTax.ToString("c");
                countySalesTaxLabel.Text = countySalesTax.ToString("c");
                totalSalesTaxLabel.Text = totalSalesTax.ToString("c");
                totalCostLabel.Text = totalCost.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
