using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal OT_MULTIPLIER = 1.5m;
                const decimal BASE_HOURS_PER_WEEK = 40m;

                decimal hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                decimal hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                
                if (hoursWorked > BASE_HOURS_PER_WEEK)
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS_PER_WEEK;
                    decimal basePay = BASE_HOURS_PER_WEEK * hourlyPayRate;
                    decimal overtimePay = overtimeHours * (hourlyPayRate * OT_MULTIPLIER);
                    decimal grossPayWithOvertime = basePay + overtimePay;

                    grossPayLabel.Text = grossPayWithOvertime.ToString("c");
                }
                else
                {
                    decimal grossPayNoOvertime = hoursWorked * hourlyPayRate;

                    grossPayLabel.Text = grossPayNoOvertime.ToString("c");
                }

                clearButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
