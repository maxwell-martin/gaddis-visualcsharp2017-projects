using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double weightInPounds;
            double heightInInches;

            if (double.TryParse(weightTextBox.Text, out weightInPounds) && double.TryParse(heightTextBox.Text,
                out heightInInches) && weightInPounds >= 0.0 && heightInInches >= 0.0)
            {
                double bmi = (weightInPounds) * (703.0) / (Math.Pow(heightInInches, 2.0));

                if (bmi < 18.5)
                {
                    bmiLabel.Text = bmi.ToString("n1");
                    MessageBox.Show("You are underweight.");
                }
                else if (bmi >= 18.5 && bmi <= 25.0)
                {
                    bmiLabel.Text = bmi.ToString("n1");
                    MessageBox.Show("You are optimal weight.");
                }
                else if (bmi >= 25.0)
                {
                    bmiLabel.Text = bmi.ToString("n1");
                    MessageBox.Show("You are overweight.");
                }
            }
            else
            {
                MessageBox.Show("The input entered is invalid.");
                weightTextBox.Clear();
                heightTextBox.Clear();
                weightTextBox.Focus();
            }
        }
    }
}
