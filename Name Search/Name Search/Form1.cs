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

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> boys = new List<string>();
        List<string> girls = new List<string>();

        StreamReader boysInputFile = File.OpenText("BoyNames.txt");
        StreamReader girlsInputFile = File.OpenText("GirlNames.txt");

        string boyName;
        string girlName;

        private void ReadBoysFile()
        {
            int count = 0;

            while (!boysInputFile.EndOfStream)
            {
                boys.Add(boysInputFile.ReadLine());
                count++;
            }

            boysInputFile.Close();
        }

        private void ReadGirlsFile()
        {
            int count = 0;

            while (!girlsInputFile.EndOfStream)
            {
                girls.Add(girlsInputFile.ReadLine());
                count++;
            }

            girlsInputFile.Close();
        }

        private string GetBoyName()
        {
            boyName = boyNameTextBox.Text;

            return boyName;
        }

        private string GetGirlName()
        {
            girlName = girlNameTextBox.Text;

            return girlName;
        }

        private int SequentialSearch(List<string> inputList, string name)
        {
            bool found = false;
            int position = -1;
            int index = 0;

            while (!found && index < inputList.Count)
            {
                if (inputList[index] == name)
                {
                    position = index;
                    found = true;
                }

                index++;
            }

            return position;
        }

        private void CompareBoyName(string boyName)
        {
            if (SequentialSearch(boys, boyName) != -1)
            {
                MessageBox.Show("The name '" + boyName + "' is among the most popular for boys.");
            }
            else
            {
                MessageBox.Show("The name '" + boyName + "' is not among the most popular boys.");
            }
        }

        private void CompareGirlName(string girlName)
        {
            if (SequentialSearch(girls, girlName) != -1)
            {
                MessageBox.Show("The name '" + girlName + "' is among the most popular for girls.");
            }
            else
            {
                MessageBox.Show("The name '" + girlName + "' is not among the most popular for girls.");
            }
        }

        private void CompareBothNames(string boyName, string girlName)
        {
            if ( (SequentialSearch(boys, boyName) != -1) && (SequentialSearch(girls, girlName) != -1) )
            {
                MessageBox.Show("The name '" + boyName + "' is among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is among the most popular for girls.");
            }
            else if ( (SequentialSearch(boys, boyName) != -1) && (SequentialSearch(girls, girlName) == -1) )
            {
                MessageBox.Show("The name '" + boyName + "' is among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is not among the most popular for girls.");
            }
            else if ((SequentialSearch(boys, boyName) == -1) && (SequentialSearch(girls, girlName) != -1))
            {
                MessageBox.Show("The name '" + boyName + "' is not among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is among the most popular for girls.");
            }
            else
            {
                MessageBox.Show("The name '" + boyName + "' is not among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is not among the most popular for girls.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            GetBoyName();
            GetGirlName();

            if (boyName != "" && girlName != "")
            {
                CompareBothNames(boyName, girlName);
                boyNameTextBox.Focus();
            } 
            else if (boyName != "" && girlName == "")
            {
                CompareBoyName(boyName);
                boyNameTextBox.Focus();
            }
            else if (girlName != "" && boyName == "")
            {
                CompareGirlName(girlName);
                girlNameTextBox.Focus();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadBoysFile();
            ReadGirlsFile();
        }
    }
}
