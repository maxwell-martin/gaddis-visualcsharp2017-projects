using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Number_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }
    }
}
