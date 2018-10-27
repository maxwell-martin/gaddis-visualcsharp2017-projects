using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            detailListBox.Items.Clear();

            const decimal INTEREST_RATE = 0.005m;

            decimal balance;
            int months;
            int count = 1;

            if (decimal.TryParse(startingBalTextBox.Text, out balance) && balance >= 0.00m)
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months >= 0)
                {
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);

                        string endingBalance = "The ending balance for month " + count + " is " + balance.ToString("c");

                        detailListBox.Items.Add(endingBalance);

                        /* Instead of initializing and setting a string variable, you can put a string inside of the Add method:
                         * detailListBox.Items.Add(""The ending balance for month " + count + " is " + balance.ToString("c")); */

                        count += 1;
                    }

                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for balance.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Clear();
            monthsTextBox.Clear();
            endingBalanceLabel.Text = "";

            detailListBox.Items.Clear();

            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
