using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int UPDATE_AMT = 10;
            const double KPH_CONVERSION = 0.6214;

            int kph;
            double mph;

            for (kph = START_SPEED; kph <= END_SPEED; kph += UPDATE_AMT)
            {
                mph = kph * KPH_CONVERSION;

                outputListBox.Items.Add(kph + " KPH is the same as " + mph + " MPH");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
