using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coin_Toss2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();

            outputListBox.Items.Clear();

            for (int count = 0; count < 5; count++)
            {
                myCoin.Toss();
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
