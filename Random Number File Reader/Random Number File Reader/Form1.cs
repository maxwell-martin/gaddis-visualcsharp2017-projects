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

namespace Random_Number_File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);
                    int number;
                    int total = 0;
                    int count = 0;

                    while (!inputFile.EndOfStream)
                    {
                        number = int.Parse(inputFile.ReadLine());
                        numbersListBox.Items.Add(number);

                        total += number;

                        count++;
                    }

                    numbersListBox.Items.Add("\n");
                    numbersListBox.Items.Add("Total: " + total);
                    numbersListBox.Items.Add("Number of random numbers read: " + count);

                    MessageBox.Show("Hooray! \n \nAll numbers from: \n \n" + openFile.FileName + "\n \nhave been read.");
                }
                else
                {
                    MessageBox.Show("The operation was canceled.");
                    openButton.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
