using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pennies_for_Pay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int daysWorked;

            const double PENNY = 0.01;

            if(int.TryParse(daysTextBox.Text, out daysWorked) && daysWorked >= 1)
            {
                double pay = PENNY;

                payListBox.Items.Clear();
                payListBox.Items.Add("Pay");
                payListBox.Items.Add("");

                for (int day = 1; day <= daysWorked; day++)
                {
                    payListBox.Items.Add("After day " + day + " you have made: " + pay.ToString("c"));

                    pay += pay;
                }
            }
            else
            {
                MessageBox.Show("The input entered is invalid.");
            }
        }
    }
}
