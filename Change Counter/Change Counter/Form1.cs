using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal NICKEL = 0.05m;
        const decimal DIME = 0.10m;
        const decimal QUARTER = 0.25m;
        const decimal HALF_DOLLAR = 0.50m;
        private decimal total = 0.00m; 

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCents_Click(object sender, EventArgs e)
        {
            total = total + NICKEL; //Same as 'total += NICKEL;'
            totalLabel.Text = total.ToString("C");
        }

        private void tenCents_Click(object sender, EventArgs e)
        {
            total = total + DIME; //Same as 'total += DIME;'
            totalLabel.Text = total.ToString("C");
        }

        private void twentyfiveCents_Click(object sender, EventArgs e)
        {
            total = total + QUARTER; //Same as 'total += QUARTER;'
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCents_Click(object sender, EventArgs e)
        {
            total = total + HALF_DOLLAR; //Same as 'total += HALF_DOLLAR;'
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
