using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Numbers
{
    public partial class Form1 : Form
    {
        private int number;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref int number)
        {
            bool isValid = false;

            if (int.TryParse(numberTextBox.Text, out number) && number >= 0)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("Invalid input.");
                numberTextBox.Clear();
                numberTextBox.Focus();
            }

            return isValid;
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref number))
            {
                if (IsPrime(number) && number != 0 && number != 1)
                {
                    MessageBox.Show("The number is prime!!!");
                    numberTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("The number is not prime.");
                    numberTextBox.Focus();
                }
            }
        }
    }
}
