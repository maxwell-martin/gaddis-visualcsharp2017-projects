using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Club_Points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int pointsFor0Books = 0;
            const int pointsFor1Book = 5;
            const int pointsFor2Books = 15;
            const int pointsFor3Books = 30;
            const int pointsFor4OrMoreBooks = 60;

            int books;

            if (int.TryParse(booksTextBox.Text, out books) && books >= 0)
            {
                switch (books)
                {
                    case 0:
                        pointsLabel.Text = pointsFor0Books.ToString();
                        break;
                    case 1:
                        pointsLabel.Text = pointsFor1Book.ToString();
                        break;
                    case 2:
                        pointsLabel.Text = pointsFor2Books.ToString();
                        break;
                    case 3:
                        pointsLabel.Text = pointsFor3Books.ToString();
                        break;
                    default:
                        break;
                }
                if (books >= 4)
                {
                    pointsLabel.Text = pointsFor4OrMoreBooks.ToString();
                }

                booksTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a whole number (must be less than or equal to 2147483647).");
            }
        }
    }
}
