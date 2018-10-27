using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AShiftSupervisor
{
    public partial class Form1 : Form
    {
        private const decimal MIN_YEARLY_SALARY = 15600m;
        private const int BONUS_PRODUCTION_AMT = 100;

        string name;
        int number;
        decimal salary;
        int productionAmt;

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
                    if (decimal.TryParse(salaryTextBox.Text, out salary) && salary >= MIN_YEARLY_SALARY)
                    {
                        if (int.TryParse(productionAmtTextBox.Text, out productionAmt) && productionAmt >= 0)
                        {
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Production amount is invalid.");
                            productionAmtTextBox.Clear();
                            productionAmtTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Salary is invalid.");
                        salaryTextBox.Clear();
                        salaryTextBox.Focus();
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

        private bool GotBonus(int productionAmt)
        {
            if (productionAmt >= BONUS_PRODUCTION_AMT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearAll()
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
            salaryTextBox.Clear();
            productionAmtTextBox.Clear();
        }

        private void bonusStatusButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                ShiftSupervisor theSupervisor = new ShiftSupervisor(name, number, salary);

                if (GotBonus(productionAmt))
                {
                    MessageBox.Show("Name: " + theSupervisor.Name + "\n\nNumber: " + theSupervisor.Number + "\n\n" +
                        "Salary: " + theSupervisor.Salary.ToString("c") + "\n\nProduction Amount: " + productionAmt + 
                        "\n\nBonus Eligibility Staus: Eligible\n\nBonus Amount: " + theSupervisor.Bonus.ToString("c"));
                }
                else
                {
                    MessageBox.Show("Name: " + theSupervisor.Name + "\n\nNumber: " + theSupervisor.Number + "\n\n" +
                        "Salary: " + theSupervisor.Salary.ToString("c") + "\n\nProduction Amount: " + productionAmt + 
                        "\n\nBonus Eligibility Staus: Ineligible");
                }

                ClearAll();

                nameTextBox.Focus();
            }
        }
    }
}
