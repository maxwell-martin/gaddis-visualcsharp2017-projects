using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int year;
        private int month;
        private int day;

        private bool GetData(CDAccount account)
        {
            bool valid = false;
            
            decimal interestRate;
            decimal balance;

            if (accountNumberTextBox.Text != "" && accountNumberTextBox.Text != null)
            {
                account.AccountNumber = accountNumberTextBox.Text;

                if (decimal.TryParse(interestRateTextBox.Text, out interestRate) && interestRate > 0m)
                {
                    account.InterestRate = interestRate;

                    if (decimal.TryParse(balanceTextBox.Text, out balance) && balance >= 0m)
                    {
                        account.Balance = balance;

                        if (maturityDateTextBox.Text != "" && maturityDateTextBox.Text != null && GetDate(maturityDateTextBox.Text))
                        {
                            DateTime dateTime = new DateTime(year, month, day);
                            account.MaturityDate = dateTime.Date;
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Maturity date is invalid.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Balance is invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Interest rate is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Account number is invalid.");
            }

            return valid;
        }

        private void DisplayData(CDAccount account)
        {
            accountNumberLabel.Text = account.AccountNumber;
            interestRateLabel.Text = account.InterestRate.ToString("p");
            balanceLabel.Text = account.Balance.ToString("c");
            maturityDateLabel.Text = account.MaturityDate.ToShortDateString();
        }

        private bool GetDate(string date)
        {
            bool valid = false;

            if (char.IsNumber(date[0]) && char.IsNumber(date[1]) && char.IsNumber(date[3]) &&
                char.IsNumber(date[4]) && char.IsNumber(date[6]) && char.IsNumber(date[7]) && 
                char.IsNumber(date[8]) && char.IsNumber(date[9]))
            {
                year = int.Parse(date.Substring(6, 4));
                month = int.Parse(date.Substring(0, 2));
                day = int.Parse(date.Substring(3, 2));

                valid = true;
            }
            else
            {
                MessageBox.Show("Date is invalid. \n\nMust be in the format (MM/DD/YYYY).");
            }

            return valid;
        } 

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CDAccount userAcct = new CDAccount();

            if (GetData(userAcct))
            {
                DisplayData(userAcct);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
