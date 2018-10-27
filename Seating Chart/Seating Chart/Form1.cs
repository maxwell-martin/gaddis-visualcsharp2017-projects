using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            int row;
            int col;

            const int MAX_ROW = 5;
            const int MAX_COL = 3;

            decimal[,] prices = { {450m, 450m, 450m, 450m},
                                  {425m, 425m, 425m, 425m},
                                  {400m, 400m, 400m, 400m},
                                  {375m, 375m, 375m, 375m},
                                  {375m, 375m, 375m, 375m},
                                  {350m, 350m, 350m, 350m}, };

            if (int.TryParse(txtRow.Text, out row) && row >= 0 && row <= MAX_ROW)
            {
                if (int.TryParse(txtCol.Text, out col) && col >= 0 && col <= MAX_COL)
                {
                    priceLabel.Text = prices[row, col].ToString("c");
                }
                else
                {
                    MessageBox.Show("Column must be an integer 0 through " + MAX_COL);
                }
            }
            else
            {
                MessageBox.Show("Row must be an integer 0 through " + MAX_ROW);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
