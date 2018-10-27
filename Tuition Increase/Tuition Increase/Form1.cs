using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Increase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double TUITION_INC_PERCENTAGE_PER_YEAR = 0.02;

            double tuitionAmt = 6000.00;

            for (int year = 1; year <= 5; year++)
            {
                tuitionAmt += (tuitionAmt * TUITION_INC_PERCENTAGE_PER_YEAR);

                tuitionListBox.Items.Add("The tuition after year " + year + " will be: " + tuitionAmt.ToString("c"));
            }
        }
    }
}
