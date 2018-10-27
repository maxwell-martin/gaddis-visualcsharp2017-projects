using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Calorie_Calculator
{
    public partial class Form1 : Form
    {
        const double NUMBER_OF_COOKIES_IN_ONE_BAG = 40.0;
        const double NUMBER_OF_SERVINGS_PER_BAG = 10.0;
        const double NUMBER_OF_CALORIES_PER_SERVING = 300.0;

        const double NUMBER_OF_COOKIES_PER_SERVING = NUMBER_OF_COOKIES_IN_ONE_BAG / NUMBER_OF_SERVINGS_PER_BAG;
        const double NUMBER_OF_CALORIES_PER_COOKIE = NUMBER_OF_CALORIES_PER_SERVING / NUMBER_OF_COOKIES_PER_SERVING;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double numberOfCookiesEaten = double.Parse(cookiesTextBox.Text);
                double numberOfCaloriesEaten = numberOfCookiesEaten * NUMBER_OF_CALORIES_PER_COOKIE;

                caloriesLabel.Text = numberOfCaloriesEaten.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
