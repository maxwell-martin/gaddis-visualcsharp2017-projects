using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void discountEligibilityButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string name = nameTB.Text;
            string address = addressTB.Text;
            string telephone = telephoneTB.Text;
            int customerNumber = rand.Next();
            decimal totalPurchases = decimal.Parse(totalPurchasesTB.Text);

            PreferredCustomer thePFC = new PreferredCustomer(name, address, telephone, customerNumber, totalPurchases);

            if (totalPurchases >= 500m && totalPurchases < 1000m)
            {
                thePFC.DiscountLevel = 0.05m;
                MessageBox.Show("You are eligibile for a " + thePFC.DiscountLevel.ToString("p") + " discount on" +
                    "all future purchases.");
            }
            else if (totalPurchases >= 1000m && totalPurchases < 1500m)
            {
                thePFC.DiscountLevel = 0.06m;
                MessageBox.Show("You are eligibile for a " + thePFC.DiscountLevel.ToString("p") + " discount on " +
                    "all future purchases.");
            }
            else if (totalPurchases >= 1500m && totalPurchases < 2000m)
            {
                thePFC.DiscountLevel = 0.07m;
                MessageBox.Show("You are eligibile for a " + thePFC.DiscountLevel.ToString("p") + " discount on " +
                    "all future purchases.");
            }
            else if (totalPurchases >= 2000m)
            {
                thePFC.DiscountLevel = 0.10m;
                MessageBox.Show("You are eligibile for a " + thePFC.DiscountLevel.ToString("p") + " discount on " +
                    "all future purchases.");
            }
            else
            {
                thePFC.DiscountLevel = 0.00m;
                MessageBox.Show("You are not eligibile for a discount on all future purchases. To be eligible for the " +
                    "a discount, please spend at least " + (500 - totalPurchases).ToString("n2") + " more dollars.");
            }
        }
    }
}
