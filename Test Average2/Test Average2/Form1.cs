using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Average2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Average(int[] iArray)
        {
            int total = 0;
            double average;

            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            average = (double) total / iArray.Length;

            return average;
        }

        private int FindHighest(int[] iArray)
        {
            int highest = iArray[0];

            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }

            return highest;
        }

        private int FindLowest(int[] iArray)
        {
            int lowest = iArray[0];
            
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
            }

            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 5;
                int[] scores = new int[SIZE];

                int index = 0;
                int highestScore, lowestScore;
                double averageScore;

                StreamReader inputFile = File.OpenText("TestScores2.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                highestScore = FindHighest(scores);
                lowestScore = FindLowest(scores);
                averageScore = Average(scores);

                highScoreLabel.Text = highestScore.ToString();
                lowScoreLabel.Text = lowestScore.ToString();
                averageScoreLabel.Text = averageScore.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
