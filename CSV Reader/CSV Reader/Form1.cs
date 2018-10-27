using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                averagesListBox.Items.Clear();

                string line;

                int count = 0;
                int total;

                double average;

                char[] delim = { ',' };

                StreamReader inputFile = File.OpenText("Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    count++;
                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    total = 0;

                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    average = (double) total / tokens.Length;

                    averagesListBox.Items.Add("The average grade for student " + count + " is " + average.ToString("n1"));
                }

                inputFile.Close();
            }
            catch
            {
                MessageBox.Show("File is unreadable.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
