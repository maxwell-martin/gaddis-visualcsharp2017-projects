using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class Form1 : Form
    {
        const int BANANA_CALORIES = 115;
        const int APPLE_CALORIES = 80;
        const int ORANGE_CALORIES = 90;
        const int PEAR_CALORIES = 120;

        private int totalCalories = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bananaPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += BANANA_CALORIES;

            caloriesLabel.Text = totalCalories.ToString();
            
        }

        private void applePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += APPLE_CALORIES;

            caloriesLabel.Text = totalCalories.ToString();
        }

        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += ORANGE_CALORIES;

            caloriesLabel.Text = totalCalories.ToString();
        }

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += PEAR_CALORIES;

            caloriesLabel.Text = totalCalories.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            caloriesLabel.Text = totalCalories.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
