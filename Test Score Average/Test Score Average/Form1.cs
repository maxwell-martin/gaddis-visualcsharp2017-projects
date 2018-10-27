using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        const double HIGH_SCORE = 95.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1 = double.Parse(test1TextBox.Text);
                double test2 = double.Parse(test2TextBox.Text);
                double test3 = double.Parse(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n1");

                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Great job!");
                }

                clearButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
