using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int ROWS = 3;
        private const int COLS = 3;

        private const int O_VALUE = 0;
        private const int X_VALUE = 1;

        int[,] gamePieces = new int[ROWS, COLS];
        string[,] letters = new string[ROWS, COLS];

        Random rand = new Random();

        private void GetXsAndOs(int[,] gamePieces)
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    gamePieces[row, col] = rand.Next(2);
                }
            }
        }

        private void ConvertToLetters(int[,] gamePieces)
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (gamePieces[row, col] == 0)
                    {
                        letters[row, col] = "O";
                    }
                    else
                    {
                        letters[row, col] = "X";
                    }
                }
            }
        }

        private void GetWinner()
        {
            if (gamePieces[0,0] == gamePieces[0,1] && gamePieces[0,1] == gamePieces[0,2])
            {
                resultsLabel.Text = letters[0, 0] + " wins!";
            }
            else if (gamePieces[1, 0] == gamePieces[1, 1] && gamePieces[1, 1] == gamePieces[1, 2])
            {
                resultsLabel.Text = letters[1, 0] + " wins!";
            }
            else if (gamePieces[2, 0] == gamePieces[2, 1] && gamePieces[2, 1] == gamePieces[2, 2])
            {
                resultsLabel.Text = letters[2, 0] + " wins!";
            }
            else if (gamePieces[0, 0] == gamePieces[1, 0] && gamePieces[1, 0] == gamePieces[2, 0])
            {
                resultsLabel.Text = letters[0, 0] + " wins!";
            }
            else if (gamePieces[0, 1] == gamePieces[1, 1] && gamePieces[1, 1] == gamePieces[2, 1])
            {
                resultsLabel.Text = letters[0, 1] + " wins!";
            }
            else if (gamePieces[0, 2] == gamePieces[1, 2] && gamePieces[1, 2] == gamePieces[2, 2])
            {
                resultsLabel.Text = letters[0, 2] + " wins!";
            }
            else if (gamePieces[0, 0] == gamePieces[1, 1] && gamePieces[1, 1] == gamePieces[2, 2])
            {
                resultsLabel.Text = letters[0, 0] + " wins!";
            }
            else if (gamePieces[0, 2] == gamePieces[1, 1] && gamePieces[1,1] == gamePieces[2, 0])
            {
                resultsLabel.Text = letters[0, 2] + " wins!";
            }
            else
            {
                resultsLabel.Text = "Tie!";
            }
        }

        private void DisplayLetters(string[,] letters)
        {
            label0Comma0.Text = letters[0, 0].ToString();
            label0Comma1.Text = letters[0, 1].ToString();
            label0Comma2.Text = letters[0, 2].ToString();
            label1Comma0.Text = letters[1, 0].ToString();
            label1Comma1.Text = letters[1, 1].ToString();
            label1Comma2.Text = letters[1, 2].ToString();
            label2Comma0.Text = letters[2, 0].ToString();
            label2Comma1.Text = letters[2, 1].ToString();
            label2Comma2.Text = letters[2, 2].ToString();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            GetXsAndOs(gamePieces);
            ConvertToLetters(gamePieces);
            DisplayLetters(letters);
            GetWinner();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
