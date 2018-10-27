using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int randomNumber1;
        int randomNumber2;

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber1 = rand.Next(401) + 100;
            randomNumber2 = rand.Next(401) + 100;

            questionLabel.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ";
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            int answer = randomNumber1 + randomNumber2;

            int inputAnswer;

            if (int.TryParse(answerTextBox.Text, out inputAnswer) && inputAnswer >= 0)
            {
                if (inputAnswer == answer)
                {
                    MessageBox.Show("You are correct. " + randomNumber1 + " + " + randomNumber2
                        + " = " + inputAnswer);

                    randomNumber1 = rand.Next(401) + 100;
                    randomNumber2 = rand.Next(401) + 100;

                    questionLabel.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ";

                    answerTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Sorry. You are incorrect. " + randomNumber1 + " + " + randomNumber2
                        + " does not equal " + inputAnswer);

                    randomNumber1 = rand.Next(401) + 100;
                    randomNumber2 = rand.Next(401) + 100;

                    questionLabel.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ";

                    answerTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer greater than 0.");

                answerTextBox.Clear();
            }
        }
    }
}
