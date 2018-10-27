using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Random_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCardButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(cardImageList.Images.Count);

            cardPictureBox.Image = cardImageList.Images[randomNumber];
        }
    }
}
