using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sales_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int SIZE = 7;

        decimal[] sales = new decimal[SIZE];

        private void ReadFile(decimal[] iArray)
        {
            try
            {
                int position = 0;

                StreamReader inputFile = File.OpenText("Sales.txt");

                while ( (position < iArray.Length) && (!inputFile.EndOfStream) )
                {
                    iArray[position] = decimal.Parse(inputFile.ReadLine());
                    position++;
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayFile(decimal[] iArray)
        {
            foreach (decimal value in iArray)
            {
                salesListBox.Items.Add(value.ToString("c"));
            }
        }

        private decimal Total(decimal[] iArray)
        {
            decimal total = 0m;

            foreach (decimal value in iArray)
            {
                total += value;
            }

            totalLabel.Text = total.ToString("c");

            return total;
        }

        private void Average(decimal[] iArray)
        {
            decimal total = Total(iArray);
            decimal average = total / iArray.Length;

            averageLabel.Text = average.ToString("c");
        }

        private void Largest(decimal[] iArray)
        {
            decimal largest = iArray[0];

            for (int index = 1; index < iArray.Length; index++)
            {
                if (largest < iArray[index])
                {
                    largest = iArray[index];
                }
            }

            largestLabel.Text = largest.ToString("c");
        }

        private void smallest(decimal[] iArray)
        {
            decimal smallest = iArray[0];

            for (int index = 1; index < iArray.Length; index++)
            {
                if (smallest > iArray[index])
                {
                    smallest = iArray[index];
                }
            }

            smallestLabel.Text = smallest.ToString("c");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Clear();

            ReadFile(sales);
            DisplayFile(sales);
            Total(sales);
            Average(sales);
            Largest(sales);
            smallest(sales);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
