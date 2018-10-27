using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsNumberValid(string str)
        {
            const int VALID_LENGTH = 13;
            bool isValid;

            if (str.Length == VALID_LENGTH && (str[0] == '(') && (str[4] == ')') && (str[8] == '-') )
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void Unformat(ref string number)
        {
            number = number.Remove(0, 1);
            number = number.Remove(3, 1);
            number = number.Remove(6, 1);
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string number = numberTextBox.Text.Trim();

            if (IsNumberValid(number))
            {
                Unformat(ref number);

                MessageBox.Show("Unformatted number: " + number);
            }
            else
            {
                MessageBox.Show("Number entered is invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
