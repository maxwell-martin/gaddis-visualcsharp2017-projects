using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Burned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double CALORIES_BURNED_PER_MINUTE = 3.9;

            double caloriesBurned = 0.0;

            for (int minute = 10; minute <= 30; minute += 5)
            {
                caloriesBurned = (minute * CALORIES_BURNED_PER_MINUTE);

                caloriesListBox.Items.Add("After " + minute + " minutes, you have burned " + caloriesBurned + " calories.");
            }
        }
    }
}
