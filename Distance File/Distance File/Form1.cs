using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Distance_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int speed, hours, distance;

            if (int.TryParse(speedTextBox.Text, out speed) && int.TryParse(hoursTextBox.Text, out hours) && speed >= 1 && hours >= 1)
            {
                StreamWriter inputFile = File.CreateText("Distance.txt");

                for (int count = 1; count <= hours; count++)
                {
                    distance = speed * count;

                    inputFile.WriteLine("After hour " + count + " the distance is " + distance + " miles");
                }

                inputFile.Close();

                MessageBox.Show("Calculations written to the file: Distance.txt");
            }
            else
            {
                MessageBox.Show("The input entered is invalid.");

                speedTextBox.Clear();
                hoursTextBox.Clear();
                speedTextBox.Focus();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
