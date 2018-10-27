using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_of_Numbers_in_a_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool failedFormatting = false;

        private bool IsInputValid(string str)
        {
            bool isValid = true;
            int index = 0;

            if (str != "" && str != null)
            {
                while (index < str.Length && isValid)
                {
                    if (!char.IsDigit(str[index]) && str[index] != ',')
                    {
                        isValid = false;
                    }

                    index++;
                }
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private double Sum(string str)
        {
            double total = 0;

            str = str.Trim();

            char[] delim = { ',' };
            string[] tokens = str.Split(delim);

            try
            {
                foreach (string token in tokens)
                {
                    total += int.Parse(token);
                }
            }
            catch
            {
                MessageBox.Show("Input invalid.");
                failedFormatting = true;
                inputTextBox.Clear();
                inputTextBox.Focus();
            }

            return total;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            double sumOfValues;

            if (IsInputValid(input))
            {
                sumOfValues = Sum(input);

                if (!failedFormatting)
                {
                    MessageBox.Show("The sum of the values is:\n\n" + sumOfValues);
                    inputTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
        }
    }
}
