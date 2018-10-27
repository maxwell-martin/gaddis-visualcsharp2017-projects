using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberOfPackages;

            if(int.TryParse(packagesTextBox.Text, out numberOfPackages) && numberOfPackages >= 0)
            {
                const double packagePrice = 99.00;
                const double ten2NineteenPackages_DiscountPercentage = 0.20;
                const double twenty2FortyNinePackages_DiscountPercentage = 0.30;
                const double fifty2NinetyNinePackages_DiscountPercentage = 0.40;
                const double oneHundredOrMorePackages_DiscountPercentage = 0.50;

                if (numberOfPackages < 10)
                {
                    double subTotal = numberOfPackages * packagePrice;
                    double discountAmt = 0.0;
                    double total = subTotal - discountAmt;

                    discountLabel.Text = discountAmt.ToString("c");
                    totalLabel.Text = total.ToString("c");

                }
                else if (numberOfPackages >= 10 && numberOfPackages <= 19)
                {
                    double subTotal = numberOfPackages * packagePrice;
                    double discountAmt = subTotal * ten2NineteenPackages_DiscountPercentage;
                    double total = subTotal - discountAmt;

                    discountLabel.Text = discountAmt.ToString("c");
                    totalLabel.Text = total.ToString("c");
                }
                else if (numberOfPackages >= 20 && numberOfPackages <= 49)
                {
                    double subTotal = numberOfPackages * packagePrice;
                    double discountAmt = subTotal * twenty2FortyNinePackages_DiscountPercentage;
                    double total = subTotal - discountAmt;

                    discountLabel.Text = discountAmt.ToString("c");
                    totalLabel.Text = total.ToString("c");
                }
                else if (numberOfPackages >= 50 && numberOfPackages <= 99)
                {
                    double subTotal = numberOfPackages * packagePrice;
                    double discountAmt = subTotal * fifty2NinetyNinePackages_DiscountPercentage;
                    double total = subTotal - discountAmt;

                    discountLabel.Text = discountAmt.ToString("c");
                    totalLabel.Text = total.ToString("c");
                }
                else if (numberOfPackages >= 100)
                {
                    double subTotal = numberOfPackages * packagePrice;
                    double discountAmt = subTotal * oneHundredOrMorePackages_DiscountPercentage;
                    double total = subTotal - discountAmt;

                    discountLabel.Text = discountAmt.ToString("c");
                    totalLabel.Text = total.ToString("c");
                }

                packagesTextBox.Focus();
            }
            else
            {
                MessageBox.Show("The input that you entered is invalid.");

                packagesTextBox.Clear();
                packagesTextBox.Focus();

            }
        }
    }
}
