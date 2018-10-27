using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            string name, id, track;

            if (nameTextBox.Text != "" && nameTextBox.Text != null)
            {
                name = nameTextBox.Text;

                if (idTextBox.Text != "" && idTextBox.Text != null)
                {
                    id = idTextBox.Text;

                    if (infoSystemsRadioButton.Checked)
                    {
                        track = "Information Systems";

                        CompSciStudent theStudent = new CompSciStudent(name, id, track);

                        requiredHoursLabel.Text = theStudent.RequiredHours.ToString();
                    }
                    else if (softwareEngineeringRadioButton.Checked)
                    {
                        track = "Software Engineering";

                        CompSciStudent theStudent = new CompSciStudent(name, id, track);

                        requiredHoursLabel.Text = theStudent.RequiredHours.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please select an Academic Track.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an ID number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
