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
            try
            {
                double weightInPounds = double.Parse(weightTextBox.Text);
                double heightInInches = double.Parse(heightTextBox.Text);
                double bmi = (weightInPounds) * (703.0) / (Math.Pow(heightInInches, 2.0));

                bmiLabel.Text = bmi.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
