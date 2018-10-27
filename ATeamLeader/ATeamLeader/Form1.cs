using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATeamLeader
{
    public partial class Form1 : Form
    {
        private const decimal MIN_HOURLY_WAGE = 7.50m;

        List<TeamLeader> teamLeaders = new List<TeamLeader>();

        string name;
        int number;
        int shiftNumber;
        decimal hourlyPayRate;
        int trainingHoursAttended;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid()
        {
            bool valid = false;

            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                name = nameTextBox.Text;

                if (int.TryParse(numberTextBox.Text, out number) && number > 0)
                {
                    if (int.TryParse(shiftNumberTextBox.Text, out shiftNumber) && (shiftNumber == 1 || shiftNumber == 2
                        || shiftNumber == 3))
                    {
                        if (decimal.TryParse(payRateTextBox.Text, out hourlyPayRate) && hourlyPayRate >= MIN_HOURLY_WAGE)
                        {
                            if (int.TryParse(trainingHoursTextBox.Text, out trainingHoursAttended) && trainingHoursAttended >= 0)
                            {
                                valid = true;
                            }
                            else
                            {
                                MessageBox.Show("Training hours attended is invalid.");
                                trainingHoursTextBox.Clear();
                                trainingHoursTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Salary is invalid.");
                            payRateTextBox.Clear();
                            payRateTextBox.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Number is invalid.");
                    numberTextBox.Clear();
                    numberTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Name is invalid.");
                nameTextBox.Clear();
                nameTextBox.Focus();
            }

            return valid;
        }

        private void ClearAll()
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
            shiftNumberTextBox.Clear();
            payRateTextBox.Clear();
            trainingHoursTextBox.Clear();
        }

        private bool ExistsAlready(List<TeamLeader> inputList, TeamLeader inputTeamLeader)
        {
            bool found = false;
            int index = 0;

            while (!found && index < inputList.Count)
            {
                if (inputList[index].Name == inputTeamLeader.Name)
                {
                    found = true;
                }

                index++;
            }

            return found;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                TeamLeader theTeamLeader = new TeamLeader(name, number, shiftNumber, hourlyPayRate, trainingHoursAttended);

                if (!ExistsAlready(teamLeaders, theTeamLeader))
                {
                    teamLeaders.Add(theTeamLeader);
                    teamLeadersListBox.Items.Add(theTeamLeader.Name);
                    ClearAll();
                    nameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(theTeamLeader.Name + " exists already.");
                    ClearAll();
                    nameTextBox.Focus();
                }
                
            }
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            int sIndex = teamLeadersListBox.SelectedIndex;

            if (sIndex != -1)
            {
                if (teamLeaders[sIndex].AttendedEnoughTraining(teamLeaders[sIndex].TrainingHoursAttended))
                {
                    MessageBox.Show("Name: " + teamLeaders[sIndex].Name + "\n\nNumber: " + teamLeaders[sIndex].Number +
                        "\n\nShiftNumber: " + teamLeaders[sIndex].ShiftNumber + "\n\nHourly Pay rate: " +
                        teamLeaders[sIndex].HourlyPayRate.ToString("c") + "\n\nTraining Hours Attended: " +
                        teamLeaders[sIndex].TrainingHoursAttended + "\n\nTraining Staus: PASS");
                }
                else
                {
                    MessageBox.Show("Name: " + teamLeaders[sIndex].Name + "\n\nNumber: " + teamLeaders[sIndex].Number +
                        "\n\nShiftNumber: " + teamLeaders[sIndex].ShiftNumber + "\n\nHourly Pay rate: " +
                        teamLeaders[sIndex].HourlyPayRate.ToString("c") + "\n\nTraining Hours Attended: " +
                        teamLeaders[sIndex].TrainingHoursAttended + "\n\nTraining Staus: FAIL");
                }
            }
        }
    }
}
