using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardOneButton_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Two of Clubs; Black";
        }

        private void cardTwoButton_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Six of Hearts; Red";
        }

        private void cardThreeButton_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Jack of Clubs; Black";
        }

        private void cardFourButton_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Ace of Diamonds; Red";
        }

        private void cardFiveButton_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Ten of Hearts; Red";
        }
    }
}
