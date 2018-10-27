using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal mass, weight;
            const decimal weightHeavyLimit = 1000m;
            const decimal weightLightLimit = 10m;
            const decimal constantValue = 9.8m;

            if (decimal.TryParse(massTextBox.Text, out mass))
            {
                if (mass >= 0m)
                {
                    weight = mass * constantValue;
                    
                    if (weight > weightHeavyLimit)
                    {
                        MessageBox.Show("The object is too heavy.");
                        massTextBox.Text = "";
                        weightLabel.Text = "";
                        massTextBox.Focus();
                    }
                    else if (weight < weightLightLimit)
                    {
                        MessageBox.Show("The object is too light.");
                        massTextBox.Text = "";
                        weightLabel.Text = "";
                        massTextBox.Focus();
                    }
                    else
                    {
                        weightLabel.Text = weight.ToString("n");
                        massTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a decimal that is greater than or " +
                        "equal to zero.");

                    massTextBox.Text = "";
                    weightLabel.Text = "";
                    massTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a decimal.");

                massTextBox.Text = "";
                weightLabel.Text = "";
                massTextBox.Focus();
            }

        }
    }
}
