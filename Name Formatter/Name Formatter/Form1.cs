using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void format1_Click(object sender, EventArgs e)
        {
            String format1 = titleTextBox.Text + " " + firstNameTextBox.Text + " "
                + middleNameTextBox.Text + " " + lastNameTextBox.Text;

            formattedNameLabel.Text = format1;

        }

        private void format2_Click(object sender, EventArgs e)
        {
            String format2 = firstNameTextBox.Text + " "
                + middleNameTextBox.Text + " " + lastNameTextBox.Text;

            formattedNameLabel.Text = format2;
        }

        private void format3_Click(object sender, EventArgs e)
        {
            String format3 = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            formattedNameLabel.Text = format3;
        }

        private void format4_Click(object sender, EventArgs e)
        {
            String format4 = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " "
                + middleNameTextBox.Text + ", " + titleTextBox.Text;

            formattedNameLabel.Text = format4;
        }

        private void format5_Click(object sender, EventArgs e)
        {
            String format5 = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " "
                + middleNameTextBox.Text;

            formattedNameLabel.Text = format5;
        }

        private void format6_Click(object sender, EventArgs e)
        {
            String format6 = lastNameTextBox.Text + ", " + firstNameTextBox.Text;

            formattedNameLabel.Text = format6;
        }
    }
}
