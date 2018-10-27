using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            int month, day, year;

            if (int.TryParse(monthTextBox.Text, out month) && int.TryParse(dayTextBox.Text, out day) && 
                int.TryParse(yearTextBox.Text, out year))
            {
                if (month >= 1 && month <= 12 && day >= 1 && day <= 31 && year >= 0 && year <= 99)
                {
                    monthTextBox.Text = month.ToString("d2");
                    dayTextBox.Text = day.ToString("d2");
                    yearTextBox.Text = year.ToString("d2");

                    int monthTimesDay = month * day;

                    if (monthTimesDay == year)
                    {
                        MessageBox.Show("The date is magic.");

                        monthTextBox.Text = "";
                        dayTextBox.Text = "";
                        yearTextBox.Text = "";

                        monthTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("The date is not magic.");

                        monthTextBox.Text = "";
                        dayTextBox.Text = "";
                        yearTextBox.Text = "";

                        monthTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The input that you entered is invalid.");

                    monthTextBox.Text = "";
                    dayTextBox.Text = "";
                    yearTextBox.Text = "";

                    monthTextBox.Focus();
                }               
            }
            else
            {
                MessageBox.Show("The input that you entered is invalid.");

                monthTextBox.Text = "";
                dayTextBox.Text = "";
                yearTextBox.Text = "";

                monthTextBox.Focus();
            }
        }
    }
}
