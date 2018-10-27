using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }

        private void TurnLightOff()
        {
            lightOffPictureBox.Visible = true;
            lightOnPictureBox.Visible = false;
            lightStateLabel.Text = "OFF";
        }
        
        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOnPictureBox.Visible)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
