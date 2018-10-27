using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Costs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double loan = double.Parse(loanTextBox.Text);
                double insurance = double.Parse(insuranceTextBox.Text);
                double gas = double.Parse(gasTextBox.Text);
                double oil = double.Parse(oilTextBox.Text);
                double tires = double.Parse(tiresTextBox.Text);
                double maintenance = double.Parse(maintenanceTextBox.Text);

                double totalMonthlyExpenses = loan + insurance + gas + oil + tires + maintenance;
                double totalYearlyExpenses = totalMonthlyExpenses * 12.0;

                loanTextBox.Text = loan.ToString("c");
                insuranceTextBox.Text = insurance.ToString("c");
                gasTextBox.Text = gas.ToString("c");
                oilTextBox.Text = oil.ToString("c");
                tiresTextBox.Text = tires.ToString("c");
                maintenanceTextBox.Text = maintenance.ToString("c");

                monthlyExpensesLabel.Text = totalMonthlyExpenses.ToString("c");
                yearlyExpensesLabel.Text = totalYearlyExpenses.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loanTextBox.Text = "";
            insuranceTextBox.Text = "";
            gasTextBox.Text = "";
            oilTextBox.Text = "";
            tiresTextBox.Text = "";
            maintenanceTextBox.Text = "";

            monthlyExpensesLabel.Text = "";
            yearlyExpensesLabel.Text = "";

            loanTextBox.Focus();
        }
    }
}
