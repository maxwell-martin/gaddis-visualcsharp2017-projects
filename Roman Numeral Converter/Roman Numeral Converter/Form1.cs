using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int inputNumber;

            if (int.TryParse(numberTextBox.Text, out inputNumber))
            {
                if (inputNumber >= 1 && inputNumber <= 10)
                {
                    switch (inputNumber)
                    {
                        case 1:
                            romanNumeralLabel.Text = "I";
                            break;
                        case 2:
                            romanNumeralLabel.Text = "II";
                            break;
                        case 3:
                            romanNumeralLabel.Text = "III";
                            break;
                        case 4:
                            romanNumeralLabel.Text = "IV";
                            break;
                        case 5:
                            romanNumeralLabel.Text = "V";
                            break;
                        case 6:
                            romanNumeralLabel.Text = "VI";
                            break;
                        case 7:
                            romanNumeralLabel.Text = "VII";
                            break;
                        case 8:
                            romanNumeralLabel.Text = "VIII";
                            break;
                        case 9:
                            romanNumeralLabel.Text = "IX";
                            break;
                        case 10:
                            romanNumeralLabel.Text = "X";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 10");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }

            numberTextBox.Focus();
        }
    }
}
