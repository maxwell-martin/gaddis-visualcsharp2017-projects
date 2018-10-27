using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game
{
    public partial class MainForm : Form
    {
        int year;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsInputValid()
        {
            bool isValid = false;

            if (int.TryParse(yearTextBox.Text, out year) && makeTextBox.Text != "" && makeTextBox.Text != null)
            {
                isValid = true;
            }

            return isValid;
        }

        private void Clear()
        {
            yearTextBox.Clear();
            makeTextBox.Clear();
        }

        public void startButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                GameForm newGame = new GameForm();
                newGame.yearLabel.Text = year.ToString();
                newGame.makeLabel.Text = makeTextBox.Text;
                newGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid input.");
                Clear();
                yearTextBox.Focus();
            }
        }
    }
}
