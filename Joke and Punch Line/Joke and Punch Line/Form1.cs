using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_and_Punch_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            jokeAndPunchLineLabel.Text = "Why did the chicken cross the road?";
        }

        private void punchLineButton_Click(object sender, EventArgs e)
        {
            jokeAndPunchLineLabel.Text = "To get to the other side.";
        }
    }
}
