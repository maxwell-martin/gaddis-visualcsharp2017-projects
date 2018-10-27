using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int randomNumber;
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = rand.Next(100) + 1;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int guess;

            if (int.TryParse(guessTextBox.Text, out guess) && (guess >= 1 && guess <= 100))
            {
                count++;

                if (guess == randomNumber)
                {
                    MessageBox.Show("Correct! Great job.\nIt took you " + count + " tries to guess the answer correctly.");

                    randomNumber = rand.Next(100) + 1;

                    guessTextBox.Clear();
                    guessTextBox.Focus();
                    count = 0;
                }
                else if (guess > randomNumber)
                {
                    MessageBox.Show("Too high, please try again.");
                    guessTextBox.Clear();
                    guessTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Too low, please try again.");
                    guessTextBox.Clear();
                    guessTextBox.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Please enter an integer in the range 1-100.");
                guessTextBox.Clear();
                guessTextBox.Focus();
            }
        }
    }
}
