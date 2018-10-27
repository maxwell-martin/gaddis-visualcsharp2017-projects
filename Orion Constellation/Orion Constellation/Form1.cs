using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = true;
            alnitakLabel.Visible = true;
            saiphLabel.Visible = true;
            alnilamLabel.Visible = true;
            mintakaLabel.Visible = true;
            meissaLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = false;
            alnitakLabel.Visible = false;
            saiphLabel.Visible = false;
            alnilamLabel.Visible = false;
            mintakaLabel.Visible = false;
            meissaLabel.Visible = false;
            rigelLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
