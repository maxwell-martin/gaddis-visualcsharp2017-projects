using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double organisms;
            double percentIncrease;
            double daysToMultiply;

            populationListBox.Items.Add("Day | Approximate Population");

            if (double.TryParse(organismsTextBox.Text, out organisms) && double.TryParse(percentIncreaseTextBox.Text, out percentIncrease)
                && double.TryParse(daysToMultiplyTextBox.Text, out daysToMultiply) && organisms >= 1.0 && percentIncrease >= 1.0 &&
                daysToMultiply >= 1.0)
            {
                double increaseAmount;

                percentIncrease = percentIncrease / 100;

                for (int day = 1; day <= daysToMultiply; day++)
                {
                    populationListBox.Items.Add(day + " | " + organisms);

                    increaseAmount = organisms * percentIncrease;

                    organisms += increaseAmount;
                }
            }
            else
            {
                MessageBox.Show("The data entered is invalid.");
            }
        }
    }
}
