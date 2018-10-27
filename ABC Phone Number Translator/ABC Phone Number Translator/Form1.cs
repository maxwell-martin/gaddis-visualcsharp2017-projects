using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Phone_Number_Translator
{
    enum LettersToNumbers
    {
        ABC = 2, DEF = 3, GHI = 4, JKL = 5, MNO = 6, PQRS = 7, TUV = 8, WXYZ = 9
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref string str)
        {
            bool valid;

            str = str.Trim();

            if (str.Length == 12 && char.IsLetterOrDigit(str[0]) && char.IsLetterOrDigit(str[1])
                && char.IsLetterOrDigit(str[2]) && str[3] == '-' && char.IsLetterOrDigit(str[4])
                && char.IsLetterOrDigit(str[5]) && char.IsLetterOrDigit(str[6]) && str[7] == '-'
                && char.IsLetterOrDigit(str[8]) && char.IsLetterOrDigit(str[9])
                && char.IsLetterOrDigit(str[10]) && char.IsLetterOrDigit(str[11]))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
            
        }

        private void MakeUpperCase(ref string str)
        {
            foreach (char value in str)
            {
                str = str.Replace(value, char.ToUpper(value));
            }
        }

        private string Format(string str)
        {
            string number;

            foreach (char value in str)
            {
                if (!char.IsNumber(value) && value != '-')
                {
                    if (value == 'A' || value == 'B' || value == 'C')
                    {
                        number = ((int)LettersToNumbers.ABC).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'D' || value == 'E' || value == 'F')
                    {
                        number = ((int)LettersToNumbers.DEF).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'G' || value == 'H' || value == 'I')
                    {
                        number = ((int)LettersToNumbers.GHI).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'J' || value == 'K' || value == 'L')
                    {
                        number = ((int)LettersToNumbers.JKL).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'M' || value == 'N' || value == 'O')
                    {
                        number = ((int)LettersToNumbers.MNO).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'P' || value == 'Q' || value == 'R' || value == 'S')
                    {
                        number = ((int)LettersToNumbers.PQRS).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else if (value == 'T' || value == 'U' || value == 'V')
                    {
                        number = ((int)LettersToNumbers.TUV).ToString();
                        str = str.Replace(value, number[0]);
                    }
                    else
                    {
                        number = ((int)LettersToNumbers.WXYZ).ToString();
                        str = str.Replace(value, number[0]);
                    }
                }
            }

            return str;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string formattedString;

            if (IsInputValid(ref input))
            {
                MakeUpperCase(ref input);
                formattedString = Format(input);
                MessageBox.Show(formattedString);

            }
            else
            {
                MessageBox.Show("Input invalid.");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
        }
    }
}
