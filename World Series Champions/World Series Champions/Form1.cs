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

namespace World_Series_Champions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> teamsListWinnersAtLeastOnce = new List<string>();
        List<string> teamsListWinners1903to2012 = new List<string>();

        StreamReader winnersAtLeaseOnceInputFile = File.OpenText("Teams.txt");
        StreamReader winners1903to2012InputFile = File.OpenText("WorldSeriesWinners.txt");

        string selectedTeam;

        private void ReadAndDisplayWinnersAtLeastOnceFile()
        {
            int count = 0;

            while (!winnersAtLeaseOnceInputFile.EndOfStream)
            {
                teamsListWinnersAtLeastOnce.Add(winnersAtLeaseOnceInputFile.ReadLine());
                teamsListBox.Items.Add(teamsListWinnersAtLeastOnce[count]);
                count++;
            }

            winnersAtLeaseOnceInputFile.Close();
        }

        private void ReadWinners1903to2012File()
        {
            int count = 0;

            while (!winners1903to2012InputFile.EndOfStream)
            {
                teamsListWinners1903to2012.Add(winners1903to2012InputFile.ReadLine());
                count++;
            }

            winners1903to2012InputFile.Close();
        }

        private int CalculateNumberWon(string selectedTeam)
        {
            int count = 0;

            foreach(string team in teamsListWinners1903to2012)
            {
                if (team == selectedTeam)
                {
                    count++;
                }
            }

            return count;
        }

        private void DisplayNumberWon()
        {
            int numberWon = CalculateNumberWon(selectedTeam);
            MessageBox.Show("The " + selectedTeam + " have won the World Series " +
                "a total of " + numberWon + " time(s).");
        }

        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = teamsListBox.SelectedItem.ToString();
            DisplayNumberWon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadAndDisplayWinnersAtLeastOnceFile();
            ReadWinners1903to2012File();
        }
    }
}
