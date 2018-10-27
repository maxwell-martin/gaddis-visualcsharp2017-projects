using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double handlingStressDays = 3.0;
            const double timeManagementDays = 3.0;
            const double supervisionSkillsDays = 3.0;
            const double negotiationDays = 5.0;
            const double howToInterviewDays = 1.0;

            const double handlingStressPrice = 1000.0;
            const double timeManagementPrice = 800.0;
            const double supervisionSkillsPrice = 1500.0;
            const double negotiationPrice = 1300.0;
            const double howToInterviewPrice = 500.0;

            const double austinLodgingPricePerDay = 150.0;
            const double chicagoLodgingPricePerDay = 225.0;
            const double dallasLodgingPricePerDay = 175.0;
            const double orlandoLodgingPricePerDay = 300.0;
            const double phoenixLodgingPricePerDay = 175.0;
            const double raleighLodgingPricePerDay = 150.0;

            if (workshopListBox.SelectedIndex != -1 && locationListBox.SelectedIndex != -1)
            {
                string selectedWorkshop = workshopListBox.SelectedItem.ToString();
                string selectedLocation = locationListBox.SelectedItem.ToString();

                if (selectedWorkshop == "Handling Stress" && selectedLocation == "Austin")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * austinLodgingPricePerDay;

                    lodgingLabel.Text = austinLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Chicago")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * chicagoLodgingPricePerDay;

                    lodgingLabel.Text = chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Dallas")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * dallasLodgingPricePerDay;

                    lodgingLabel.Text = dallasLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Orlando")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * orlandoLodgingPricePerDay;

                    lodgingLabel.Text = orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Phoenix")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * phoenixLodgingPricePerDay;

                    lodgingLabel.Text = phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Raleigh")
                {
                    registrationLabel.Text = handlingStressPrice.ToString("c0");

                    double totalLodgingCost = handlingStressDays * raleighLodgingPricePerDay;

                    lodgingLabel.Text = raleighLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = handlingStressPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Austin")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * austinLodgingPricePerDay;

                    lodgingLabel.Text = austinLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Chicago")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * chicagoLodgingPricePerDay;

                    lodgingLabel.Text = chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Dallas")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * dallasLodgingPricePerDay;

                    lodgingLabel.Text = dallasLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Orlando")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * orlandoLodgingPricePerDay;

                    lodgingLabel.Text = orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Phoenix")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * phoenixLodgingPricePerDay;

                    lodgingLabel.Text = phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Raleigh")
                {
                    registrationLabel.Text = timeManagementPrice.ToString("c0");

                    double totalLodgingCost = timeManagementDays * raleighLodgingPricePerDay;

                    lodgingLabel.Text = raleighLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = timeManagementPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Austin")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * austinLodgingPricePerDay;

                    lodgingLabel.Text = austinLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Chicago")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * chicagoLodgingPricePerDay;

                    lodgingLabel.Text = chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Dallas")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * dallasLodgingPricePerDay;

                    lodgingLabel.Text = dallasLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Orlando")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * orlandoLodgingPricePerDay;

                    lodgingLabel.Text = orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Phoenix")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * phoenixLodgingPricePerDay;

                    lodgingLabel.Text = phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Raleigh")
                {
                    registrationLabel.Text = supervisionSkillsPrice.ToString("c0");

                    double totalLodgingCost = supervisionSkillsDays * raleighLodgingPricePerDay;

                    lodgingLabel.Text = raleighLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = supervisionSkillsPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Austin")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * austinLodgingPricePerDay;

                    lodgingLabel.Text = austinLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Chicago")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * chicagoLodgingPricePerDay;

                    lodgingLabel.Text = chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Dallas")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * dallasLodgingPricePerDay;

                    lodgingLabel.Text = dallasLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Orlando")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * orlandoLodgingPricePerDay;

                    lodgingLabel.Text = orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Phoenix")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * phoenixLodgingPricePerDay;

                    lodgingLabel.Text = phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Raleigh")
                {
                    registrationLabel.Text = negotiationPrice.ToString("c0");

                    double totalLodgingCost = negotiationDays * raleighLodgingPricePerDay;

                    lodgingLabel.Text = raleighLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = negotiationPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Austin")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * austinLodgingPricePerDay;

                    lodgingLabel.Text = austinLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Chicago")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * chicagoLodgingPricePerDay;

                    lodgingLabel.Text = chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Dallas")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * dallasLodgingPricePerDay;

                    lodgingLabel.Text = dallasLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Orlando")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * orlandoLodgingPricePerDay;

                    lodgingLabel.Text = orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Phoenix")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * phoenixLodgingPricePerDay;

                    lodgingLabel.Text = phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Raleigh")
                {
                    registrationLabel.Text = howToInterviewPrice.ToString("c0");

                    double totalLodgingCost = howToInterviewDays * raleighLodgingPricePerDay;

                    lodgingLabel.Text = raleighLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0");

                    double totalCost = howToInterviewPrice + totalLodgingCost;

                    totalLabel.Text = totalCost.ToString("c0");
                }
            }
            else
            {
                MessageBox.Show("Please select a workshop and a location.");
            }

        }
    }
}
