using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falling_Distance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double GRAVITY = 9.8;

        private double FallingDistance(double seconds)
        {
            double distance = (0.5)* (GRAVITY) * (Math.Pow(seconds, 2));

            return distance;
        }

        private bool IsInputValid(ref double timeInSeconds)
        {
            bool isValid = false;

            if (double.TryParse(timeTextBox.Text, out timeInSeconds) && timeInSeconds >= 0)
            {
                timeInSeconds = Math.Round(timeInSeconds, 2);
                timeTextBox.Text = timeInSeconds.ToString();
                isValid = true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.");
                timeTextBox.Clear();
                timeTextBox.Focus();
            }

            return isValid;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double timeInSeconds = 0, distance;

            if(IsInputValid(ref timeInSeconds))
            {
                distance = Math.Round(FallingDistance(timeInSeconds), 2);

                distanceLabel.Text = distance.ToString("n");

                timeTextBox.Focus();
            }
        }
    }
}
