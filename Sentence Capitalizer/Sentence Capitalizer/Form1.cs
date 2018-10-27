using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Capitalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Capitalize2(string str)
        {
            //int index = 0;

            str = str.Trim();

            string[] words = new string[str.Length];

            /*while (index < str.Length)
            {
                while (index < str.Length && !char.IsWhiteSpace(str[index]))
                {
                    words[index] = str.Substring(index, str.IndexOf(' ', index));
                    index += words[index].Length;
                }

                while (index < str.Length && char.IsWhiteSpace(str[index]))
                {
                    index++;
                }
            }*/

            string extractedWord;

            /*for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    extractedWord += str[i];
                }

                words[i] = extractedWord;
            }*/

            int count = 0;
            int index = 0;
            while (count < str.Length)
            {
                extractedWord = "";

                while (count < str.Length && !char.IsWhiteSpace(str[count]))
                {
                    extractedWord += str[count];
                    count++;
                }

                words[index] = extractedWord;
                index++;

                count++;

                //while (count < str.Length && char.IsWhiteSpace(str[count]))
                //{
                //    count++;
                //}
            }

            string upperCasedLetter;

            for (int x = 0; x < words.Length; x++)
            {
                foreach (string word in words)
                {
                    if (!char.IsUpper(word[0]))
                    {
                        words[x] = word.Remove(0, 1);
                        upperCasedLetter = char.ToUpper(word[0]).ToString();
                        words[x] = upperCasedLetter + words[x];
                    }
                }
            }

            string formattedSentence = "";

            foreach (string fixedWord in words)
            {
                formattedSentence = fixedWord + " ";
            }

            formattedSentence = formattedSentence.Trim();

            return formattedSentence;
        }

        private string Capitalize(string str)
        {
            string formattedString = "";

            List<string> endingPunctuation = new List<string>();

            foreach(char value in str)
            {
                if (value == '.' || value == '!' || value == '?')
                {
                    endingPunctuation.Add(value.ToString());
                }
            }

            char[] delim = { '.', '?', '!' };

            string[] tokens = str.Trim().Split(delim, StringSplitOptions.RemoveEmptyEntries);

            for (int index = 0; index < tokens.Length; index++)
            {
                tokens[index] = tokens[index].Trim();
                string firstLetter = tokens[index].Substring(0, 1);
                string restOfLetters = tokens[index].Substring(1, tokens[index].Length - 1);

                if (!char.IsUpper(firstLetter[0]))
                {
                    firstLetter = firstLetter.ToUpper();
                    tokens[index] = firstLetter + restOfLetters;
                }
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                formattedString = formattedString + tokens[i] + endingPunctuation[i] + " ";
            }

            formattedString = formattedString.Trim();

            return formattedString;
        }

        private void capitalizeButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string formattedInput;

            if (input != "" && input != null)
            {
                formattedInput = Capitalize(input);
                MessageBox.Show("Formatted string:\n\n" + formattedInput);
            }
            else
            {
                MessageBox.Show("Please enter a sentence.");
            }
        }
    }
}
