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

namespace Exam_Scores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int SIZE = 3;

        int[][] jaggedArray = new int[SIZE][];

        StreamReader inputFileSection1 = File.OpenText("Section1.txt");
        StreamReader inputFileSection2 = File.OpenText("Section2.txt");
        StreamReader inputFileSection3 = File.OpenText("Section3.txt");

        double averageSection1;
        double averageSection2;
        double averageSection3;
        double overallAverage;

        double highestOverallScore;
        double lowestOverallScore;

        List<string> sectionHighest = new List<string>();
        List<string> sectionLowest = new List<string>();

        private void InitializeJaggedArray()
        {
            jaggedArray[0] = new int[12];
            jaggedArray[1] = new int[8];
            jaggedArray[2] = new int[10];
        }

        private void ReadFiles()
        {
            try
            {
                int index1 = 0;
                int index2 = 0;
                int index3 = 0;

                while (!inputFileSection1.EndOfStream)
                {
                    jaggedArray[0][index1] = int.Parse(inputFileSection1.ReadLine());
                    index1++;
                }

                while (!inputFileSection2.EndOfStream)
                {
                    jaggedArray[1][index2] = int.Parse(inputFileSection2.ReadLine());
                    index2++;
                }

                while (!inputFileSection3.EndOfStream)
                {
                    jaggedArray[2][index3] = int.Parse(inputFileSection3.ReadLine());
                    index3++;
                }
            }
            catch
            {
                MessageBox.Show("File(s) unreadable.");
            }
            
        }

        private void DisplayScores(int[][] jaggedArray, int index1, int index2, int index3)
        {
            for (int position = 0; position < jaggedArray[index1].Length; position++)
            {
                sect1ListBox.Items.Add(jaggedArray[index1][position].ToString());
            }

            for (int position = 0; position < jaggedArray[index2].Length; position++)
            {
                sect2ListBox.Items.Add(jaggedArray[index2][position].ToString());
            }

            for (int position = 0; position < jaggedArray[index3].Length; position++)
            {
                sect3ListBox.Items.Add(jaggedArray[index3][position].ToString());
            }

        }

        private double GetAverage(int[][] jaggedArray, int index)
        {
            double average;
            int total = 0;

            for (int col = 0; col < jaggedArray[index].Length; col++)
            {
                total += jaggedArray[index][col];
            }

            average = (double) total / jaggedArray[index].Length;

            return average;
        }

        private void DisplayAverageSection1(double average)
        {
            avgSect1Label.Text = average.ToString("n2");
        }

        private void DisplayAverageSection2(double average)
        {
            avgSect2Label.Text = average.ToString("n2");
        }
        private void DisplayAverageSection3(double average)
        {
            avgSect3Label.Text = average.ToString("n2");
        }

        private double GetOverallAverage(double average1, double average2, double average3)
        {
            double total = average1 + average2 + average3;
            double average = total / 3.0;

            return average;
        }

        private void DisplayOverallAverage(double average)
        {
            overallAvgLabel.Text = average.ToString("n2");
        }

        private double FindHighestOverallScore(int[][] jaggedArray)
        {
            highestOverallScore = jaggedArray[0][0];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (highestOverallScore < jaggedArray[row][col])
                    {
                        highestOverallScore = jaggedArray[row][col];
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (highestOverallScore == jaggedArray[row][col])
                    {
                        sectionHighest.Add((row + 1).ToString());
                    }
                }
            }

            return highestOverallScore;
        }

        private void DisplayHighestOverallScore(double highest)
        {
            highestScoreLabel.Text = highest.ToString("n2");

            string str = "";

            for (int index = 0; index < sectionHighest.Count - 1; index++)
            {
                str += (sectionHighest[index] + ",");
            }

            str += sectionHighest[sectionHighest.Count - 1];

            highestScoreSectLabel.Text = str;
        }

        private double FindLowestOverallScore(int[][] jaggedArray)
        {
            lowestOverallScore = jaggedArray[0][0];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (lowestOverallScore > jaggedArray[row][col])
                    {
                        lowestOverallScore = jaggedArray[row][col];
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (lowestOverallScore == jaggedArray[row][col])
                    {
                        sectionLowest.Add((row + 1).ToString());
                    }
                }
            }


            return lowestOverallScore;
        }

        private void DisplayLowestOverallScore(double lowest)
        {
            lowestScoreLabel.Text = lowest.ToString("n2");

            string str = "";

            for (int index = 0; index < sectionLowest.Count - 1; index++)
            {
                str += (sectionLowest[index] + ",");
            }

            str += sectionLowest[sectionLowest.Count - 1];

            lowestScoreSectLabel.Text = str;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            InitializeJaggedArray();
            ReadFiles();

            DisplayScores(jaggedArray, 0, 1, 2);

            averageSection1 = GetAverage(jaggedArray, 0);
            DisplayAverageSection1(averageSection1);

            averageSection2 = GetAverage(jaggedArray, 1);
            DisplayAverageSection2(averageSection2);

            averageSection3 = GetAverage(jaggedArray, 2);
            DisplayAverageSection3(averageSection3);

            overallAverage = GetOverallAverage(averageSection1, averageSection2, averageSection3);
            DisplayOverallAverage(overallAverage);

            highestOverallScore = FindHighestOverallScore(jaggedArray);
            DisplayHighestOverallScore(highestOverallScore);

            lowestOverallScore = FindLowestOverallScore(jaggedArray);
            DisplayLowestOverallScore(lowestOverallScore);
        }
    }
}
