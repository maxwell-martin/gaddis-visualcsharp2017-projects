using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BankAccount account = new BankAccount(1000m);

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal deposit;

            if (decimal.TryParse(depositTextBox.Text, out deposit) && deposit > 0m)
            {
                account.Deposit(deposit);
                balanceLabel.Text = account.Balance.ToString("c");
                depositTextBox.Clear();
                depositTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Deposit amount is invalid.");
                depositTextBox.Clear();
                depositTextBox.Focus();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdrawal;

            if (decimal.TryParse(withdrawTextBox.Text, out withdrawal) && withdrawal > 0m
                && account.Balance > 0m && withdrawal <= account.Balance)
            {
                account.Withdraw(withdrawal);
                balanceLabel.Text = account.Balance.ToString("c");
                withdrawTextBox.Clear();
                withdrawTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Withdrawal amount is invalid.");
                withdrawTextBox.Clear();
                withdrawTextBox.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = account.Balance.ToString("c");
        }
    }
}
