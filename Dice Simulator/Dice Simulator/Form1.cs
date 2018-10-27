using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            double roll = rand.Next(6) + 1;

            if (roll == 1)
            {
                side1PictureBox.Visible = true;
                side2PictureBox.Visible = false;
                side3PictureBox.Visible = false;
                side4PictureBox.Visible = false;
                side5PictureBox.Visible = false;
                side6PictureBox.Visible = false;
            }
            else if (roll == 2)
            {
                side1PictureBox.Visible = false;
                side2PictureBox.Visible = true;
                side3PictureBox.Visible = false;
                side4PictureBox.Visible = false;
                side5PictureBox.Visible = false;
                side6PictureBox.Visible = false;
            }
            else if (roll == 3)
            {
                side1PictureBox.Visible = false;
                side2PictureBox.Visible = false;
                side3PictureBox.Visible = true;
                side4PictureBox.Visible = false;
                side5PictureBox.Visible = false;
                side6PictureBox.Visible = false;
            }
            else if (roll == 4)
            {
                side1PictureBox.Visible = false;
                side2PictureBox.Visible = false;
                side3PictureBox.Visible = false;
                side4PictureBox.Visible = true;
                side5PictureBox.Visible = false;
                side6PictureBox.Visible = false;
            }
            else if (roll == 5)
            {
                side1PictureBox.Visible = false;
                side2PictureBox.Visible = false;
                side3PictureBox.Visible = false;
                side4PictureBox.Visible = false;
                side5PictureBox.Visible = true;
                side6PictureBox.Visible = false;
            }
            else
            {
                side1PictureBox.Visible = false;
                side2PictureBox.Visible = false;
                side3PictureBox.Visible = false;
                side4PictureBox.Visible = false;
                side5PictureBox.Visible = false;
                side6PictureBox.Visible = true;
            }
        }
    }
}
