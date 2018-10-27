using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pig_Latin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsStringValid(string str)
        {
            bool isValid = false;
            int index = 0;

            int numberOfLetters = 0;
            int numberOfNumbers = 0;
            int numberOfPunctuationMarks = 0;

            while (index < str.Length)
            {
                if (char.IsLetter(str[index]))
                {
                    numberOfLetters++;
                }
                else if (char.IsNumber(str[index]))
                {
                    numberOfNumbers++;
                }
                else if (char.IsPunctuation(str[index]))
                {
                    numberOfPunctuationMarks++;
                }

                index++;
            }

            if (numberOfLetters >= 1 && numberOfNumbers == 0 && numberOfPunctuationMarks == 0)
            {
                isValid = true;
            }

            return isValid;
        }

        private string ConvertToPigLatin(string str)
        {
            string formattedString = "";

            try
            {
                str = str.Trim().ToUpper();

                string[] tokens = str.Split();

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i].Length == 1)
                    {
                        tokens[i] += "AY";
                    }
                    else
                    {
                        tokens[i] = tokens[i].Trim();

                        string firstLetter = tokens[i].Substring(0, 1);
                        string restOfLetters = tokens[i].Substring(1);

                        tokens[i] = restOfLetters + firstLetter + "AY";
                    }
                }

                foreach (string item in tokens)
                {
                    formattedString += (item + " ");
                }

                formattedString = formattedString.Trim();
            }
            catch
            {
                MessageBox.Show("Input invalid.\n\n" +
                    "Do not use more than one space consecutively.");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }

            return formattedString;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string formattedInput;

            if (input != null && input != "" && IsStringValid(input))
            {
                formattedInput = ConvertToPigLatin(input);

                if (formattedInput != null && formattedInput != "")
                {
                    MessageBox.Show(formattedInput);
                    inputTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a string with only letters and spaces.");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
        }
    }
}
