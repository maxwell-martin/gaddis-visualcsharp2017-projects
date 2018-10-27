using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            StreamWriter outputFile;

            int numbers;
            int randomNumber;

            if (int.TryParse(numbersTextBox.Text, out numbers) && numbers > 0)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFile.FileName);

                    for (int count = 1; count <= numbers; count++)
                    {
                        randomNumber = rand.Next(100) + 1;
                        outputFile.WriteLine(randomNumber);
                    }

                    outputFile.Close();

                    MessageBox.Show("Success! " + numbers + " random numbers have been written to: \n \n \"" + saveFile.FileName + "\"");

                    numbersTextBox.Clear();
                    numbersTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("The operation was canceled.");
                    numbersTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer greater than 0.");
                numbersTextBox.Clear();
                numbersTextBox.Focus();
            }
        }
    }
}
