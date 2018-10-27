using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetNumberOfWords(string str)
        {
            int total = 0;
            int index = 0;

            str = str.Trim();

            // Algorithm to get only words
            while (index < str.Length)
            {
                while (index < str.Length && !char.IsWhiteSpace(str[index]))
                {
                    index++;
                }

                total++;

                while (index < str.Length && char.IsWhiteSpace(str[index]))
                {
                    index++;
                }
            }

            return total;

            /* Could also do this.
             * However, it does not account for multiple spaces in-between characters
             * 
             * int total = 0;
             * string[] tokens = str.Trim().Split();
             * total = tokens.Length;
             * return total;
             * 
            */
        }

        private int GetNumberOfLetters(string str)
        {
            int totalLetters = 0;
            int index = 0;

            str = str.Trim();

            while (index < str.Length)
            {
                while (index < str.Length && !char.IsWhiteSpace(str[index])
                    && !char.IsPunctuation(str[index]))
                {
                    totalLetters++;
                    index++;
                }

                while (index < str.Length && (char.IsWhiteSpace(str[index])
                    || char.IsPunctuation(str[index])) )
                {
                    index++;
                }
            }

            return totalLetters;
            
        }

        private double GetAverageLetters(int letters, int words)
        {
            double average;

            average = Math.Round( ((double) letters / words), 1, MidpointRounding.AwayFromZero );

            return average;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string entry = entryTextBox.Text;

            if (entry != "" && entry != null)
            {
                int numberOfWords = GetNumberOfWords(entry);
                int numberOfLetters = GetNumberOfLetters(entry);
                double averageLetters = GetAverageLetters(numberOfLetters, numberOfWords);

                MessageBox.Show("The total number of words is: " + numberOfWords +
                    "\nThe average number of letters per word is: " + averageLetters);
            }
            else
            {
                MessageBox.Show("Please enter a sentence.");
            }
            
        }
    }
}
