using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Separator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsStringValid(string str)
        {
            bool isValid = true;

            foreach (char value in str)
            {
                if ( (!char.IsLetter(value) && !char.IsPunctuation(value)) || value == ' ')
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private string Format(string str)
        {
            str = str.Trim();

            List<string> sentence = new List<string>();

            int pos1 = 0;
            int pos2 = 1;

            string formattedSentence;

            while (pos2 < str.Length)
            {
                if ( char.IsUpper(str[pos2]) && pos2 != str.Length - 1)
                {
                    string word = str.Substring(pos1, pos2 - pos1);
                    sentence.Add(word);
                    pos1 = pos2;
                }
                else if (pos2 == str.Length - 1 && !char.IsUpper(str[pos2]))
                {
                    string word = str.Substring(pos1, str.Length - pos1);
                    sentence.Add(word);
                }
                else if (char.IsUpper(str[pos1]) && char.IsUpper(str[pos2]))
                {
                    string secondToLast = str.Substring(pos1, 1);
                    string last = str.Substring(pos2, 1);
                    sentence.Add(secondToLast);
                    sentence.Add(last);
                }

                pos2++;
            }

            string firstLetterInFirstWord = sentence[0].Substring(0, 1);
            sentence[0] = sentence[0].Remove(0, 1);
            sentence[0] = sentence[0].Insert(0, firstLetterInFirstWord.ToUpper());

            formattedSentence = sentence[0];

            for (int i = 1; i < sentence.Count; i++)
            {
                formattedSentence += " " + sentence[i].ToLower();
            }

            formattedSentence.Trim();

            return formattedSentence;
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string formattedInput;

            if (input != "" && input != null && IsStringValid(input))
            {
                formattedInput = Format(input);
                MessageBox.Show(formattedInput);
                inputTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a string with only letters and punctuation (no spaces).");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
        }
    }
}
