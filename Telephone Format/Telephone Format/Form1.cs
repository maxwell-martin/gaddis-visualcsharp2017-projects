using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10;
            bool isValid = true;
            
            if (str.Length == VALID_LENGTH)
            {
                foreach (char value in str)
                {
                    if (!char.IsDigit(value))
                    {
                        isValid = false;
                    }
                }
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void TelephoneFormat(ref string number)
        {
            number = number.Insert(0, "(");
            number = number.Insert(4, ") ");
            number = number.Insert(9, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            string number = numberTextBox.Text.Trim();

            if (IsValidNumber(number))
            {
                TelephoneFormat(ref number);

                MessageBox.Show("Formatted number: " + number);
            }
            else
            {
                MessageBox.Show("The number you entered is invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
