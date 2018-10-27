using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total = 0.0;

            double number;

            StreamReader inputFile = File.OpenText("Sales.txt");

            while (!inputFile.EndOfStream)
            {
                if(double.TryParse(inputFile.ReadLine(), out number)) 
                {
                    total += number;
                }
                else
                {
                    inputFile.Close();

                    MessageBox.Show("Could not read data. Please make sure file has appropriate content in it.");
                }

            }

            totalLabel.Text = total.ToString("c");

            inputFile.Close();

            //Another variation of the code above with different exception handling.

            /*
            
            try
            {
                decimal total = 0.0m;
                decimal number;

                StreamReader inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream)
                {
                    number = decimal.Parse(inputFile.ReadLine());
                    total += number;
                }

                inputFile.Close();
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

            */

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
