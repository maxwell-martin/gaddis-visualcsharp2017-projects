using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles, gallonsOfGasUsed;

            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallonsOfGasUsed))
                {
                    double mpg = miles / gallonsOfGasUsed;

                    mpgLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("The input for \"gallons of gas used\" is in an incorrect format.");
                }
            }
            else
            {
                MessageBox.Show("The input for \"number of miles driven\" is in an incorrect format.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
