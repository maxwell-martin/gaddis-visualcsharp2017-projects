using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headsImage.Visible = true;
            tailsImage.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            headsImage.Visible = false;
            tailsImage.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
