using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_for_a_Dollar_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberOfPennies, numberOfNickels, numberOfDimes, numberOfQuarters;

            if (int.TryParse(penniesTextBox.Text, out numberOfPennies) && int.TryParse(nickelsTextBox.Text, out numberOfNickels)
                && int.TryParse(dimesTextBox.Text, out numberOfDimes) && int.TryParse(quartersTextBox.Text, out numberOfQuarters)
                && numberOfPennies >= 0 && numberOfNickels >= 0 && numberOfDimes >= 0 && numberOfQuarters >= 0)
            {
                const double penny = 0.01;
                const double nickel = 0.05;
                const double dime = 0.10;
                const double quarter = 0.25;
                const double dollar = 1.00;

                double penniesAmt = numberOfPennies * penny;
                double nickelsAmt = numberOfNickels * nickel;
                double dimesAmt = numberOfDimes * dime;
                double quartersAmt = numberOfQuarters * quarter;

                double totalMoneyAmt = penniesAmt + nickelsAmt + dimesAmt + quartersAmt;

                if (totalMoneyAmt == dollar)
                {
                    MessageBox.Show("WINNER WINNER CHICKEN DINNER!");

                    penniesTextBox.Clear();
                    nickelsTextBox.Clear();
                    dimesTextBox.Clear();
                    quartersTextBox.Clear();

                    penniesTextBox.Focus();
                }
                else if (totalMoneyAmt <= dollar)
                {
                    MessageBox.Show("Try again. The amount entered is less than one dollar.");

                    penniesTextBox.Clear();
                    nickelsTextBox.Clear();
                    dimesTextBox.Clear();
                    quartersTextBox.Clear();

                    penniesTextBox.Focus();
                }
                else if (totalMoneyAmt >= dollar)
                {
                    MessageBox.Show("Try again. The amount entered is more than one dollar.");

                    penniesTextBox.Clear();
                    nickelsTextBox.Clear();
                    dimesTextBox.Clear();
                    quartersTextBox.Clear();

                    penniesTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("The input entered is invalid.");

                penniesTextBox.Clear();
                nickelsTextBox.Clear();
                dimesTextBox.Clear();
                quartersTextBox.Clear();

                penniesTextBox.Focus();
            }
        }
    }
}
