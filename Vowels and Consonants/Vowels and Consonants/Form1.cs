using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowels_and_Consonants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q',
                                'r', 's', 't', 'v', 'w', 'x', 'y', 'z', 'B', 'C', 'D', 'F', 'G',
                                'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P','Q', 'R', 'S', 'T', 'V',
                                'W', 'X', 'Y', 'Z' };

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        private int GetConsonants(string strForConsonants)
        {
            int totalConsonants = 0;

            for (int i = 0; i < strForConsonants.Length; i++)
            {
                for (int z = 0; z < consonants.Length; z++)
                {
                    if (strForConsonants[i] == consonants[z])
                    {
                        totalConsonants++;
                    }
                }
            }

            return totalConsonants;
        }

        private int GetVowels(string strForVowels)
        {
            int totalVowels = 0;

            for (int i = 0; i < strForVowels.Length; i++)
            {
                for (int z = 0; z < vowels.Length; z++)
                {
                    if (strForVowels[i] == vowels[z])
                    {
                        totalVowels++;
                    }
                }
            }

            return totalVowels;
        }

        private void DisplayConsonantsAndVowels(int consonants, int vowels)
        {
            consonantsLabel.Text = consonants.ToString();
            vowelsLabel.Text = vowels.ToString();
        }

        private void sentenceTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = sentenceTextBox.Text;

            int consonants, vowels;

            consonants = GetConsonants(input);
            vowels = GetVowels(input);
            DisplayConsonantsAndVowels(consonants, vowels);
        }
    }
}
