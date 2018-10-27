using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> morseCodeCharacters = new List<string>();
        List<string> morseCodeCodes = new List<string>();

        private bool IsInputValid(ref string str)
        {
            str = str.ToUpper();

            bool valid = true;
            int index1 = 0;
            int index2 = 0;
            int counter = 0;

            while (valid && index1 < str.Length)
            {
                while (valid && index2 < morseCodeCharacters.Count)
                {
                    if (morseCodeCharacters[index2] == str[index1].ToString())
                    {
                        counter++;
                    }

                    index2++;
                }

                if (counter++ < 1)
                {
                    valid = false;
                }

                index1++;
            }

            return valid;
        }

        private string Convert(string str)
        {
            bool found = false;
            int index1 = 0;
            int index2 = 0;
            int position;
            string formattedString = "";

            while (index1 < str.Length)
            {
                while (!found && index2 < morseCodeCharacters.Count)
                {
                    if (morseCodeCharacters[index2] == str[index1].ToString())
                    {
                        found = true;
                        position = index2;
                        formattedString += morseCodeCodes[position].ToString();
                    }

                    index2++;
                }

                index2 = 0;
                found = false;
                index1++;
            }

            return formattedString;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string formattedInput;

            if (IsInputValid(ref input))
            {
                formattedInput = Convert(input);
                MessageBox.Show(formattedInput);
                inputTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Invalid input.");
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile1 = File.OpenText("MCCharacters.txt");
                StreamReader inputFile2 = File.OpenText("MCCodes.txt");

                while (!inputFile1.EndOfStream && !inputFile2.EndOfStream)
                {
                    morseCodeCharacters.Add(inputFile1.ReadLine());
                    morseCodeCodes.Add(inputFile2.ReadLine());
                }
            }
            catch
            {
                MessageBox.Show("File unreadable. Please contact software developer.");
                inputTextBox.Enabled = false;
                convertButton.Enabled = false;
            }
        }
    }
}
