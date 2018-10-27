using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProductionWorkerInfo
{
    public partial class Form1 : Form
    {
        string name, shiftName;
        int number, shiftNumber;
        double hourlyPayRate;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid()
        {
            bool valid = false;

            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                name = nameTextBox.Text;

                if (int.TryParse(employeeNumberTextBox.Text, out number) && number > 0)
                {
                    if (int.TryParse(shiftNumberTextBox.Text, out shiftNumber) && (shiftNumber == 1 || shiftNumber == 2 
                        || shiftNumber == 3))
                    {
                        shiftName = GetShiftName(shiftNumber);

                        if (double.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate) && hourlyPayRate >= 7.50)
                        {
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Hourly pay rate invalid (7.50 or greater).");
                            hourlyPayRateTextBox.Clear();
                            hourlyPayRateTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Shift number invalid (1, 2, or 3 only).");
                        shiftNumberTextBox.Clear();
                        shiftNumberTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Employee number invalid.");
                    employeeNumberTextBox.Clear();
                    employeeNumberTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.");
                nameTextBox.Clear();
                nameTextBox.Focus();
            }

            return valid;
        }

        private string GetShiftName(int shiftNumber)
        {
            if (shiftNumber == 1)
            {
                return "Day Shift"; 
            }
            else if (shiftNumber == 2)
            {
                return "Night Shift";
            }
            else
            {
                return "Mid Shift";
            }
        }

        private void ClearAll()
        {
            nameTextBox.Clear();
            employeeNumberTextBox.Clear();
            shiftNumberTextBox.Clear();
            hourlyPayRateTextBox.Clear();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                ProductionWorker theWorker = new ProductionWorker(name, number, shiftNumber, hourlyPayRate);
                MessageBox.Show("Name: " + theWorker.Name + "\n\nEmployee Number: " + theWorker.Number.ToString() +
                    "\n\nShift: " + shiftName + "\n\nHourly Pay Rate: " + theWorker.HourlyPayRate.ToString("c"));

                ClearAll();
                nameTextBox.Focus();
            }
        }
    }
}
