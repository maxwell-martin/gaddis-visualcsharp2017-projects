using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbersListBox.Items.Add(i);
                }
            }
        }
    }
}
