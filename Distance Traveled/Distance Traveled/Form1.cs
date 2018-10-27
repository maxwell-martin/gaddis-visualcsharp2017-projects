using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Traveled
{
    public partial class Form1 : Form
    {
        const double TIME_FIVE_HOURS = 5.0;
        const double TIME_EIGHT_HOURS = 8.0;
        const double TIME_TWELVE_HOURS = 12.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void distanceIn5HoursButton_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(speedTextBox.Text);
            double distance = TIME_FIVE_HOURS * speed;

            MessageBox.Show("At the speed of " + speed.ToString("n") + "mph, your car will travel "
                + distance.ToString("n") + " miles in five hours.");

        }

        private void distanceIn8HoursButton_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(speedTextBox.Text);
            double distance = TIME_EIGHT_HOURS * speed;

            MessageBox.Show("At the speed of " + speed.ToString("n") + "mph, your car will travel "
                + distance.ToString("n") + " miles in eight hours.");
        }

        private void distanceIn12HoursButton_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(speedTextBox.Text);
            double distance = TIME_TWELVE_HOURS * speed;

            MessageBox.Show("At the speed of " + speed.ToString("n") + "mph, your car will travel "
                + distance.ToString("n") + " miles in twelve hours.");
        }
    }
}
