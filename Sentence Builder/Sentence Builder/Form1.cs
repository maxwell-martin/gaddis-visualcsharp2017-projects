using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        private String SENTENCE = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            String letterA = "A";
            SENTENCE = SENTENCE + " " + letterA;

            sentenceLabel.Text = SENTENCE;
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            String wordBig = "big";
            SENTENCE = SENTENCE + " " + wordBig;

            sentenceLabel.Text = SENTENCE;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            String wordMan = "man";
            SENTENCE = SENTENCE + " " + wordMan;

            sentenceLabel.Text = SENTENCE;
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            String wordsLaughedAt = "laughed at";
            SENTENCE = SENTENCE + " " + wordsLaughedAt;

            sentenceLabel.Text = SENTENCE;
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            String wordThe = "the";
            SENTENCE = SENTENCE + " " + wordThe;

            sentenceLabel.Text = SENTENCE;
        }

        private void jokeButton_Click(object sender, EventArgs e)
        {
            String wordJoke = "joke";
            SENTENCE = SENTENCE + " " + wordJoke;

            sentenceLabel.Text = SENTENCE;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text = "";
            SENTENCE = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
