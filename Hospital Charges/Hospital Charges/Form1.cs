using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        private const decimal DAILY_RATE = 350m;

        private int days = 0;
        private decimal medicationCharges = 0m;
        private decimal surgicalCharges = 0m;
        private decimal labFees = 0m;
        private decimal rehabCharges = 0m;


        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref int days, ref decimal medicationCharges, ref decimal surgicalCharges,
            ref decimal labFees, ref decimal rehabCharges)
        {
            bool isValid = false;

            if (int.TryParse(daysTextBox.Text, out days) && days >= 0)
            {
                if (decimal.TryParse(medicationChargesTextBox.Text, out medicationCharges) && medicationCharges >= 0m)
                {
                    if (decimal.TryParse(surgicalChargesTextBox.Text, out surgicalCharges) && surgicalCharges >= 0m)
                    {
                        if (decimal.TryParse(labFeesTextBox.Text, out labFees) && labFees >= 0m)
                        {
                            if (decimal.TryParse(rehabChargesTextBox.Text, out rehabCharges) && rehabCharges >= 0m)
                            {
                                isValid = true;
                            }
                            else
                            {
                                MessageBox.Show("Rehab charges are invalid.");
                                rehabChargesTextBox.Clear();
                                rehabChargesTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lab fees are invalid.");
                            labFeesTextBox.Clear();
                            labFeesTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Surgical charges are invalid.");
                        surgicalChargesTextBox.Clear();
                        surgicalChargesTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Medication charges are invalid.");
                    medicationChargesTextBox.Clear();
                    medicationChargesTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Number of days is invalid.");
                daysTextBox.Clear();
                daysTextBox.Focus();
            }

            return isValid;
        }

        private decimal CalcStayCharges (int days)
        {
            return days * DAILY_RATE;
        }

        private decimal CalcMiscCharges()
        {
            return medicationCharges + surgicalCharges + labFees + rehabCharges;
        }

        private decimal CalcTotalCharges()
        {
            return CalcStayCharges(days) + CalcMiscCharges();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref days, ref medicationCharges, ref surgicalCharges, ref labFees, ref rehabCharges))
            {
                totalChargesLabel.Text = CalcTotalCharges().ToString("c");
            }
        }
    }
}
