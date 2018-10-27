using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (red1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (blue1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (yellow1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if (red1RadioButton.Checked && blue2RadioButton.Checked || red2RadioButton.Checked && blue1RadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (red1RadioButton.Checked && yellow2RadioButton.Checked || red2RadioButton.Checked && yellow1RadioButton.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blue1RadioButton.Checked && yellow2RadioButton.Checked || blue2RadioButton.Checked && yellow1RadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
