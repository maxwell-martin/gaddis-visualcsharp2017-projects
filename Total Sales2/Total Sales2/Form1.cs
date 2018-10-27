using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void DisplayArray(decimal[] iArray)
        {
            foreach (decimal value in iArray)
            {
                salesListBox.Items.Add(value.ToString("c"));
            }
        }

        private decimal GetTotal(decimal[] iArray)
        {
            decimal total = 0m;

            foreach (decimal value in iArray)
            {
                total += value;
            }

            return total;
        }

        private void DisplayTotal(decimal value)
        {
            totalLabel.Text = value.ToString("c");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Clear();

            const int SIZE = 7;

            decimal[] sales = new decimal[SIZE];

            ReadFile(sales);
            DisplayArray(sales);
            DisplayTotal(GetTotal(sales));

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
