using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
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
                double test1Score = double.Parse(test1TextBox.Text);
                double test2Score = double.Parse(test2TextBox.Text);
                double test3Score = double.Parse(test3TextBox.Text);
                double averageTestScore = (test1Score + test2Score + test3Score) / 3.0;

                averageLabel.Text = averageTestScore.ToString("n1");
            }
            catch (Exception ex)
            {
                /* MessageBox.Show("Please enter test scores with only numbers between"
                     + " 0 and 100."); */
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
