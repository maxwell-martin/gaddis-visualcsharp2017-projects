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

namespace Charge_Account_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int acctNumber;

        List<int> acctNumbers = new List<int>();

        StreamReader inputFile = File.OpenText("ChargeAccounts.txt");

        private void ReadFile()
        {
            try
            {
                while (!inputFile.EndOfStream)
                {
                    acctNumbers.Add(int.Parse(inputFile.ReadLine()));
                }
            }
            catch
            {
                MessageBox.Show("File not readable.");
            }

            inputFile.Close();
        }

        private bool IsInputValid(ref int acctNumber)
        {
            bool isValid = false;

            if (int.TryParse(acctNumberTextBox.Text, out acctNumber) && acctNumber >= 0)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("Please enter an integer greater than or equal to 0.");
            }

            return isValid;
        }

        private int SequentialSearch(List<int> acctNumbers, int value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < acctNumbers.Count)
            {
                if (acctNumbers[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            return position;
        }

        private void checkStatusButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref acctNumber))
            {
                ReadFile();

                if (SequentialSearch(acctNumbers, acctNumber) != -1)
                {
                    MessageBox.Show("Number is valid.");
                }
                else
                {
                    MessageBox.Show("Number is not valid.");
                }
                
            }

            acctNumberTextBox.Clear();
            acctNumberTextBox.Focus();

        }
    }
}
