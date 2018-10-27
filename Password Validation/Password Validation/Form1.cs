using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int NumberUpperCase(string str)
        {
            int totalUppercase = 0;

            foreach (char value in str)
            {
                if (char.IsUpper(value))
                {
                    totalUppercase++;
                }
            }

            return totalUppercase;
        }

        private int NumberLowerCase(string str)
        {
            int totalLowercase = 0;

            foreach (char value in str)
            {
                if (char.IsLower(value))
                {
                    totalLowercase++;

                }
            }

            return totalLowercase;
        }

        private int NumberDigits(string str)
        {
            int totalDigits = 0;

            foreach (char value in str)
            {
                if (char.IsDigit(value))
                {
                    totalDigits++;
                }
            }

            return totalDigits;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;

            int uppercase = NumberUpperCase(password);
            int lowercase = NumberLowerCase(password);
            int digits = NumberDigits(password);

            if ( (password.Length >= 8) && (uppercase >= 1) && (lowercase >= 1) && (digits >= 1) )
            {
                MessageBox.Show("The password is valid.");
                passwordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("The password is invalid.");
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
