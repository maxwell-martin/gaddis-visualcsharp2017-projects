using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        private const decimal OIL_CHANGE_PRICE = 26.00m;
        private const decimal LUBE_JOB_PRICE = 18.00m;
        private const decimal RADIATOR_FLUSH_PRICE = 30.00m;
        private const decimal TRANSMISSION_FLUSH_PRICE = 80.00m;
        private const decimal INSPECTION_PRICE = 15.00m;
        private const decimal REPLACE_MUFFLER_PRICE = 100.00m;
        private const decimal TIRE_ROTATION_PRICE = 20.00m;

        private const decimal SALES_TAX = 0.06m;

        private decimal partsCost;
        private decimal laborCost;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref decimal partsCost, ref decimal laborCost)
        {
            bool isValid = false;

            if ((decimal.TryParse(partsTextBox.Text, out partsCost) && partsCost >= 0m) || (partsTextBox.Text == "")
                || (decimal.TryParse(partsTextBox.Text.Substring(1, partsTextBox.Text.Length - 1), out partsCost)))
            {
                partsCost = Math.Round(partsCost, 2, MidpointRounding.AwayFromZero);
                partsTextBox.Text = partsCost.ToString("c");

                if ((decimal.TryParse(laborTextBox.Text, out laborCost) && laborCost >= 0m) || (laborTextBox.Text == "")
                    || (decimal.TryParse(laborTextBox.Text.Substring(1, laborTextBox.Text.Length - 1), out laborCost)))
                {
                    laborCost = Math.Round(laborCost, 2, MidpointRounding.AwayFromZero);
                    laborTextBox.Text = laborCost.ToString("c");

                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Labor cost is invalid.");
                    laborTextBox.Clear();
                    laborTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Parts cost is invalid.");
                partsTextBox.Clear();
                partsTextBox.Focus();
            }

            return isValid;
        }

        private decimal OilLubeCharges()
        {
            decimal oilAndLubeCharges = 0m;

            if (oilChangeCheckBox.Checked)
            {
                oilAndLubeCharges += OIL_CHANGE_PRICE;
            }
            if (lubeJobCheckBox.Checked)
            {
                oilAndLubeCharges += LUBE_JOB_PRICE;
            }

            return oilAndLubeCharges;
        }

        private decimal FlushCharges()
        {
            decimal flushCharges = 0m;

            if (radiatorFlushCheckBox.Checked)
            {
                flushCharges += RADIATOR_FLUSH_PRICE;
            }
            if (transmissionFlushCheckBox.Checked)
            {
                flushCharges += TRANSMISSION_FLUSH_PRICE;
            }

            return flushCharges;
        }

        private decimal MiscCharges()
        {
            decimal miscCharges = 0m;

            if (inspectionCheckBox.Checked)
            {
                miscCharges += INSPECTION_PRICE;
            }
            if (replaceMufflerCheckBox.Checked)
            {
                miscCharges += REPLACE_MUFFLER_PRICE;
            }
            if (tireRotationCheckBox.Checked)
            {
                miscCharges += TIRE_ROTATION_PRICE;
            }

            return miscCharges;
        }

        private decimal OtherCharges()
        {
            decimal otherCharges = partsCost + laborCost;

            return otherCharges; 
        }

        private decimal TaxCharges()
        {
            decimal taxCharges = partsCost * SALES_TAX;

            taxCharges = Math.Round(taxCharges, 2, MidpointRounding.AwayFromZero);

            return taxCharges;
        }

        private decimal TotalCharges()
        {
            decimal totalCharges = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();

            return totalCharges;
        }

        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Clear();
            laborTextBox.Clear();
        }

        private void ClearFees()
        {
            serviceAndLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalFeesLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref partsCost, ref laborCost))
            {
                decimal serviceCost = OilLubeCharges() + FlushCharges() + MiscCharges();
                decimal serviceAndLaborCost = serviceCost + laborCost;

                serviceAndLaborLabel.Text = serviceAndLaborCost.ToString("c");

                partsLabel.Text = partsCost.ToString("c");

                taxLabel.Text = TaxCharges().ToString("c");

                totalFeesLabel.Text = TotalCharges().ToString("c");

                clearButton.Focus();
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

            oilAndLubeGroupBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
