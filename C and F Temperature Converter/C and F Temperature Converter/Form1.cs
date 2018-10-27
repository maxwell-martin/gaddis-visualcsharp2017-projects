using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_and_F_Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void celsiusConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal fahrenheit = decimal.Parse(temperatureTextBox.Text);
                decimal convertedTemp_Celsisus = (5.0m / 9.0m) * (fahrenheit - 32.0m);

                MessageBox.Show("The temperature in Celsius is " + convertedTemp_Celsisus.ToString("n"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fahrenheitConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal celsius = decimal.Parse(temperatureTextBox.Text);
                decimal convertedTemp_Fahrenheit = ((9.0m / 5.0m) * celsius) + 32.0m;

                MessageBox.Show("The temperature in Fahrenheit is " + convertedTemp_Fahrenheit.ToString("n"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
