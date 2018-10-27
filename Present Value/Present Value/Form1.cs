using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Present_Value
{
    public partial class Form1 : Form
    {
        private double futureValue = 0.0;
        private double annualInterestRate = 0.0;
        private int years = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref double futureValue, ref double annualInterestRate, ref int years)
        {
            bool isValid = false;

            if (double.TryParse(futureValueTextBox.Text, out futureValue) && (futureValue >= 0.00 && futureValue >= 115.00))
            {
                if (double.TryParse(annualInterestRateTextBox.Text, out annualInterestRate) && (annualInterestRate >= 0.0
                    && annualInterestRate <= 20.0))
                {
                    if (int.TryParse(yearsTextBox.Text, out years) && (years >= 0 && years <= 55))
                    {
                        isValid = true;

                        futureValueTextBox.Text = futureValue.ToString("n");
                        annualInterestRateTextBox.Text = annualInterestRate.ToString("n");
                        yearsTextBox.Text = years.ToString("n0");
                    }
                    else
                    {
                        MessageBox.Show("Number of years entered is invalid.\nEnter a number in the range 0-55.");
                        yearsTextBox.Clear();
                        yearsTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Annual interest rate entered is invalid.\nEnter a number in the range 0-20.");
                    annualInterestRateTextBox.Clear();
                    annualInterestRateTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Future value entered is invalid.\nEnter a value greater than or equal to $115.00");
                futureValueTextBox.Clear();
                futureValueTextBox.Focus();
            }

            return isValid;
        }

        private double PresentValue(double futureValue, double annualInterestRate, int years)
        {
            return (futureValue / (Math.Pow((1 + (annualInterestRate / 100.0)), years)));
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref futureValue, ref annualInterestRate, ref years))
            {
                presentValueLabel.Text = PresentValue(futureValue, annualInterestRate, years).ToString("c");
            }
        }
    }
}
