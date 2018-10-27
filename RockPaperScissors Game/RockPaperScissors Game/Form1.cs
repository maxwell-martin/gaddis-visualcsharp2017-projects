using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        private int computerChoiceNumber;

        private const int ROCK_VALUE = 1;
        private const int PAPER_VALUE = 2;
        private const int SCISSORS_VALUE = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1 = rock, 2 = paper, 3 = scissors
            computerChoiceNumber = GetRandomNumber();
        }

        private int GetRandomNumber()
        {
            return rand.Next(3) + 1;
        }

        private string GetComputerChoiceName(int number)
        {
            string computerChoiceString = "";

            if(number == ROCK_VALUE)
            {
                computerChoiceString = "ROCK";
            }
            else if (number == PAPER_VALUE)
            {
                computerChoiceString = "PAPER";
            }
            else
            {
                computerChoiceString = "SCISSORS";
            }

            return computerChoiceString;
        }

        private void GetWinner(int userChoice, int computerChoice)
        {
            if (userChoice == computerChoice)
            {
                 MessageBox.Show("Tie!!! Pick again.");
            }
            else if (userChoice == ROCK_VALUE && computerChoice == PAPER_VALUE)
            {
                MessageBox.Show("You lose!!!");
            }
            else if (userChoice == ROCK_VALUE && computerChoice == SCISSORS_VALUE)
            {
                MessageBox.Show("You win!!!");
            }
            else if (userChoice == PAPER_VALUE && computerChoice == ROCK_VALUE)
            {
                MessageBox.Show("You win!!!");
            }
            else if (userChoice == PAPER_VALUE && computerChoice == SCISSORS_VALUE)
            {
                MessageBox.Show("You lose!!!");
            }
            else if (userChoice == SCISSORS_VALUE && computerChoice == ROCK_VALUE)
            {
                MessageBox.Show("You lose!!!");
            }
            else if (userChoice == SCISSORS_VALUE && computerChoice == PAPER_VALUE)
            {
                MessageBox.Show("You win!!!");
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The computer chose: \n\n" + GetComputerChoiceName(computerChoiceNumber));
            
            GetWinner(ROCK_VALUE, computerChoiceNumber);

            computerChoiceNumber = GetRandomNumber();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The computer chose: \n\n" + GetComputerChoiceName(computerChoiceNumber));

            GetWinner(PAPER_VALUE, computerChoiceNumber);

            computerChoiceNumber = GetRandomNumber();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The computer chose: \n\n" + GetComputerChoiceName(computerChoiceNumber));
            
            GetWinner(SCISSORS_VALUE, computerChoiceNumber);

            computerChoiceNumber = GetRandomNumber();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
