using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Fat_and_Carbohydrates
{
    public partial class Form1 : Form
    {
        private double fatGrams = 0, carbGrams = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private double FatCalories(double fat)
        {
            double fatCalories = fat * 9.0;
            return fatCalories;
        }

        private double CarbCalories(double carbs)
        {
            double carbCalories = carbs * 4.0;
            return carbCalories;
        }

        private bool IsInputValid(ref double fatGrams, ref double carbGrams)
        {
            bool isValid = false;

            if (double.TryParse(fatTextBox.Text, out fatGrams) && fatGrams >= 0.0)
            {
                fatGrams = Math.Round(fatGrams, 2, MidpointRounding.AwayFromZero);
                fatTextBox.Text = fatGrams.ToString();

                if (double.TryParse(carbTextBox.Text, out carbGrams) && carbGrams >= 0.0)
                {
                    carbGrams = Math.Round(carbGrams, 2, MidpointRounding.AwayFromZero);
                    carbTextBox.Text = carbGrams.ToString("n");

                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Carb grams is invalid.");
                    carbTextBox.Clear();
                    carbTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Fat grams is invalid.");
                fatTextBox.Clear();
                fatTextBox.Focus();
            }

            return isValid;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double fatCalories, carbCalories;

            if (IsInputValid(ref fatGrams, ref carbGrams))
            {
                fatCalories = FatCalories(fatGrams);
                carbCalories = CarbCalories(carbGrams);

                fatLabel.Text = fatCalories.ToString("n");
                carbLabel.Text = carbCalories.ToString("n");

                fatTextBox.Focus();
            }
        }
    }
}
