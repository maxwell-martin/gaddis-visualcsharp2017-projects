using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance
{
    public partial class Form1 : Form
    {
        const double MIN_SUGGESTED_INSURANCE_PERCENTAGE = 0.80;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double buildingReplacementCost = double.Parse(buildingAmountTextBox.Text);
                double minAmountOfInsuranceSuggested = buildingReplacementCost * MIN_SUGGESTED_INSURANCE_PERCENTAGE;

                buildingAmountTextBox.Text = buildingReplacementCost.ToString("c");
                insuranceLabel.Text = minAmountOfInsuranceSuggested.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
