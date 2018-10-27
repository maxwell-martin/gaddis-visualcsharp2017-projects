using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal distance;

            if (decimal.TryParse(distanceTextBox.Text, out distance))
            {
                const decimal inchesPerFoot = 12m;
                const decimal inchesPerYard = 36m;
                const decimal feetPerYard = 3m;

                if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
                {
                    string selectedItem1, selectedItem2;

                    selectedItem1 = fromListBox.SelectedItem.ToString();
                    selectedItem2 = toListBox.SelectedItem.ToString();

                    if (selectedItem1 == "Inches" && selectedItem2 == "Inches")
                    {
                        distanceLabel.Text = distance.ToString("n5");
                    }
                    else if (selectedItem1 == "Inches" && selectedItem2 == "Feet")
                    {
                        decimal convertedDistance = distance / inchesPerFoot;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Inches" && selectedItem2 == "Yards")
                    {
                        decimal convertedDistance = distance / inchesPerYard;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Feet" && selectedItem2 == "Inches")
                    {
                        decimal convertedDistance = distance * inchesPerFoot; ;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Feet" && selectedItem2 == "Feet")
                    {
                        distanceLabel.Text = distance.ToString("n5");
                    }
                    else if (selectedItem1 == "Feet" && selectedItem2 == "Yards")
                    {
                        decimal convertedDistance = distance / feetPerYard;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Yards" && selectedItem2 == "Inches")
                    {
                        decimal convertedDistance = distance * inchesPerYard;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Yards" && selectedItem2 == "Feet")
                    {
                        decimal convertedDistance = distance * feetPerYard;
                        distanceLabel.Text = convertedDistance.ToString("n5");
                    }
                    else if (selectedItem1 == "Yards" && selectedItem2 == "Yards")
                    {
                        distanceLabel.Text = distance.ToString("n5");
                    }
                }
                else
                {
                    MessageBox.Show("Please click an item from both lists.");
                }
            }
            else
            {
                MessageBox.Show("The input that you entered is invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
