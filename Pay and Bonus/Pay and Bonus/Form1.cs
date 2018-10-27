using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal CONTRIBUTION_PERCENTAGE = 0.05m;

        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            bool inputGood = false;

            if (decimal.TryParse(grossPayTextBox.Text, out pay) && decimal.TryParse(bonusTextBox.Text, out bonus)
                && (pay >= 0.00m) && (bonus >= 0.00m))
            {
                inputGood = true;
            }
            else
            {
                MessageBox.Show("Value(s) entered invalid. Please try again.");
            }

            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m, bonus = 0m, contribution = 0m;

            if(InputIsValid(ref grossPay, ref bonus))
            {
                contribution = (grossPay + bonus) * CONTRIBUTION_PERCENTAGE;

                contributionLabel.Text = contribution.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
