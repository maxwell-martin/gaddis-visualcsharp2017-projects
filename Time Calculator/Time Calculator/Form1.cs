using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int seconds;

            if (int.TryParse(secondsTextBox.Text, out seconds) && seconds >= 60)
            {
                const double secondsPerMinute = 60.0;
                const double secondsPerHour = 3600.0;
                const double secondsPerDay = 86400.0;

                if (seconds >= secondsPerMinute && seconds < secondsPerHour)
                {
                    double numberOfMinutes = seconds / secondsPerMinute;

                    MessageBox.Show(seconds + " seconds is equal to " + numberOfMinutes.ToString("n2") + " minutes.");
                }
                else if (seconds >= secondsPerHour && seconds < secondsPerDay)
                {
                    double numberOfHours = seconds / secondsPerHour;

                    MessageBox.Show(seconds + " seconds is equal to " + numberOfHours.ToString("n2") + " hours.");
                }
                else if (seconds >= secondsPerDay)
                {
                    double numberOfDays = seconds / secondsPerDay;

                    MessageBox.Show(seconds + " seconds is equal to " + numberOfDays.ToString("n2") + " days.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number greater than or equal to 60 seconds.");
            }
        }
    }
}
