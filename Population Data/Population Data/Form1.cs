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

namespace Population_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> populationList = new List<int>();
        List<int> annualChangeList = new List<int>();

        StreamReader inputFile = File.OpenText("USPopulation.txt");

        decimal populationAverageAnnualChange;

        int yearWithGreatestIncrease = 0;
        int yearWithLeastIncrease = 0;

        private void ReadFile()
        {
            try
            {
                while (!inputFile.EndOfStream)
                {
                    populationList.Add(int.Parse(inputFile.ReadLine()));
                }
            }
            catch
            {
                MessageBox.Show("File unreadable.");
            }

            inputFile.Close();
        }

        private decimal GetAverageAnnualChange(List<int> inputList)
        {
            decimal averageAnnualChange;
            int total = 0;

            for (int index = 0; index < inputList.Count - 1; index++)
            {
                annualChangeList.Add(inputList[index + 1] - inputList[index]);
            }
            
            foreach (int value in annualChangeList)
            {
                total += value;
            }

            averageAnnualChange = ( (decimal) total / (annualChangeList.Count + 1) );

            return averageAnnualChange;
        }

        private void DisplayAverageAnnualChange(decimal averageAnnualChange)
        {
            avgAnnualChangeLabel.Text = averageAnnualChange.ToString("n2");
        }

        private int YearWithGreatestIncrease(List<int> inputList)
        {
            int greatest = inputList[0];
            int position = 0;

            for (int index = 1; index < inputList.Count; index++)
            {
                if (inputList[index] > greatest)
                {
                    greatest = inputList[index];
                    position = index;
                }
            }

            yearWithGreatestIncrease = position + 1951;

            return yearWithGreatestIncrease;
        }

        private int YearWithLeastIncrease(List<int> inputList)
        {
            int least = inputList[0];
            int position = 0;

            for (int index = 1; index < inputList.Count; index++)
            {
                if (inputList[index] < least)
                {
                    least = inputList[index];
                    position = index;
                }
            }

            yearWithLeastIncrease = position + 1951;

            return yearWithLeastIncrease;
        }

        private void DisplayYearWithGreatestIncrease(int year)
        {
            greatestIncreaseLabel.Text = year.ToString();
        }

        private void DisplayYearWithLeastIncrease(int year)
        {
            leastIncreaseLabel.Text = year.ToString();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            ReadFile();
            populationAverageAnnualChange = GetAverageAnnualChange(populationList);
            DisplayAverageAnnualChange(populationAverageAnnualChange);
            YearWithGreatestIncrease(annualChangeList);
            YearWithLeastIncrease(annualChangeList);
            DisplayYearWithGreatestIncrease(yearWithGreatestIncrease);
            DisplayYearWithLeastIncrease(yearWithLeastIncrease);
        }
    }
}
