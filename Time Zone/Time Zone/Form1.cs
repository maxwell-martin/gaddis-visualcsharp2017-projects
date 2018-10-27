using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;

            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a city.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
