using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinetic_Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref double mass, ref double velocity)
        {
            bool isValid = false;

            if (double.TryParse(massTextBox.Text, out mass) && mass >= 0.0)
            {
                mass = Math.Round(mass, 2);

                massTextBox.Text = mass.ToString();

                if (double.TryParse(velocityTextBox.Text, out velocity) && velocity >= 0.0)
                {
                    velocity = Math.Round(velocity, 2);

                    velocityTextBox.Text = velocity.ToString();

                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Velocity entered is invalid.");

                    velocityTextBox.Clear();
                    velocityTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mass entered is invalid.");

                massTextBox.Clear();
                massTextBox.Focus();
            }

            return isValid;
        }

        private double KineticEnergy(double mass, double velocity)
        {
            return (0.5) * (mass) * (Math.Pow(velocity, 2));
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass = 0, velocity = 0, kineticEnergy;

            if (IsInputValid(ref mass, ref velocity))
            {
                kineticEnergy = KineticEnergy(mass, velocity);

                keLabel.Text = kineticEnergy.ToString("n");

                massTextBox.Focus();
            }
        }
    }
}
