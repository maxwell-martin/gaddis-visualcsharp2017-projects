using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double totalCalories, totalFatGrams;

            if (double.TryParse(caloriesTextBox.Text, out totalCalories) && double.TryParse(fatTextBox.Text, out totalFatGrams)
                && totalCalories >= 0.0 && totalFatGrams >= 0.0)
            {
                if (totalCalories == 0.0 && totalFatGrams == 0.0 && !lowFatCheckBox.Checked)
                {
                    fatCaloriesLabel.Text = "0.00";
                    fatCaloriesPercentageLabel.Text = "0.00%";
                }
                else if (totalCalories == 0.0 && totalFatGrams == 0.0 && lowFatCheckBox.Checked)
                {
                    fatCaloriesLabel.Text = "0.00";
                    fatCaloriesPercentageLabel.Text = "0.00%";

                    MessageBox.Show("The food is considered low fat.");
                }
                else
                {
                    double caloriesFromFat = totalFatGrams * 9.0;
                    double percentageCaloriesFromFat = (caloriesFromFat / totalCalories);

                    if (caloriesFromFat > totalCalories)
                    {
                        MessageBox.Show("Try again. Either the calories or fat grams were entered incorrectly.");
                    }
                    else if (caloriesFromFat <= totalCalories)
                    {
                        fatCaloriesLabel.Text = caloriesFromFat.ToString("n2");
                        fatCaloriesPercentageLabel.Text = percentageCaloriesFromFat.ToString("p");

                        percentageCaloriesFromFat *= 100;

                        if (lowFatCheckBox.Checked && percentageCaloriesFromFat < 30.0)
                        {
                            MessageBox.Show("The food is considered low fat.");
                        }
                        else if (lowFatCheckBox.Checked && percentageCaloriesFromFat >= 30.0)
                        {
                            MessageBox.Show("The food is not considered low fat.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The input entered is invalid.");
            }
        }
    }
}
