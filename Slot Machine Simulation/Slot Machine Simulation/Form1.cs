using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        int randomNumber1, randomNumber2, randomNumber3;

        double amountInserted;
        double amountWon;

        double totalInserted = 0.00;
        double totalWon = 0.00;

        private bool IsInputValid(string str)
        {
            bool isValid = false;

            try
            {
                amountInserted = double.Parse(str);

                if (amountInserted > 0.00)
                {
                    isValid = true;
                    totalInserted += amountInserted;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a dollar amount greater than 0.00.");
            }

            return isValid;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You inserted: $" + totalInserted.ToString("n2") +"\n\n" +
                "You won: $" + totalWon.ToString("n2"));
            this.Close();
        }

        private void WinOrLose(int number1, int number2, int number3)
        {
            amountWon = 0;

            if (number1 != number2 && number1 != number3 && number2 != number3)
            {
                MessageBox.Show("You have won $0.00");
            }
            else if (number1 == number2 && number1 != number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (number1 != number2 && number1 == number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (number1 != number2 && number2 == number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (number1 == number2 && number1 == number3)
            {
                amountWon = amountInserted * 3;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
        }

        private void ClearImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            string input = amountInsertedTextBox.Text;

            if (IsInputValid(input))
            {
                randomNumber1 = rand.Next(10);
                randomNumber2 = rand.Next(10);
                randomNumber3 = rand.Next(10);

                pictureBox1.Image = fruitImagelist.Images[randomNumber1];
                pictureBox2.Image = fruitImagelist.Images[randomNumber2];
                pictureBox3.Image = fruitImagelist.Images[randomNumber3];

                WinOrLose(randomNumber1, randomNumber2, randomNumber3);

                ClearImages();

                amountInsertedTextBox.Text = "";
                amountInsertedTextBox.Focus();
            }

        }
    }
}
