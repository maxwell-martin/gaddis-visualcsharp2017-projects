using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadScores(List<int> scoresList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream)
                {
                    scoresList.Add(int.Parse(inputFile.ReadLine()));
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void DisplayScores(List<int> scoresList)
        {
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        private double Average(List<int> scoresList)
        {
            double total = 0;

            for (int index = 0; index < scoresList.Count; index++)
            {
                total += scoresList[index];
            }

            /* Could also do this
             
                foreach (int score in scoresList)
                {
                    total += score;
                }
            
            */

            return total / scoresList.Count;
        }

        private int AboveAverage(List<int> scoresList)
        {
            int count = 0;
            double average = Average(scoresList);

            foreach (int score in scoresList)
            {
                if (score > average)
                {
                    count++;
                }
            }

            return count;
        }

        private int BelowAverage(List<int> scoresList)
        {
            int count = 0;
            double average = Average(scoresList);

            foreach (int score in scoresList)
            {
                if (score < average)
                {
                    count++;
                }
            }

            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            /* Only needed if you use the 2nd option for displaying to the 3 labels
            
                double averageScore;
                int numAboveAverage, numBelowAverage;
            
            */
            List<int> scoresList = new List<int>();

            ReadScores(scoresList);
            DisplayScores(scoresList);

            averageLabel.Text = Average(scoresList).ToString("n1");

            /* Could also do:
            
               averageScore = Average(scoresList);
               averageLabel.Text = averageScore.ToString("n1");

            */

            aboveAverageLabel.Text = AboveAverage(scoresList).ToString();

            /* Could also do:
            
               numAboveAverage = AboveAverage(scoresList);
               aboveAverageLabel.Text = numAboveAverage.ToString();

            */

            belowAverageLabel.Text = BelowAverage(scoresList).ToString();

            /* Could also do:
            
               numBelowAverage = BelowAverage(scoresList);
               belowAverageLabel.Text = numBelowAverage.ToString();

            */
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
