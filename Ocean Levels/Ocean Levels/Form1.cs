using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean_Levels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RISE_RATE = 1.5m;
            const int MAX_YEARS = 10;

            decimal amountRisen = 0.0m;

            for (int year = 1; year <= MAX_YEARS; year++)
            {
                amountRisen = amountRisen + RISE_RATE;

                oceanLevelListBox.Items.Add("After year " + year + ", the ocean will have risen " + amountRisen + "mm");
            }
        }
    }
}
