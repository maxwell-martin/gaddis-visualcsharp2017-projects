using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorials_Ch5_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int factorialNumber;
            int factorialTotal = 1;

            if (int.TryParse(integerTextBox.Text, out factorialNumber) && (factorialNumber >= 0 && factorialNumber < 13))
            {
                for (int count = 2; count <= factorialNumber; count++)
                {
                    factorialTotal = factorialTotal * count;
                }

                MessageBox.Show(factorialNumber + "! = " + factorialTotal);
            }
            else
            {
                MessageBox.Show("Please enter an integer in the range 0-12.");
            }
        }
    }
}
