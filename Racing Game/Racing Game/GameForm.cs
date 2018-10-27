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
    public partial class GameForm : Form
    {
        Car newCar;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            int year = int.Parse(yearLabel.Text);
            string make = makeLabel.Text;

            newCar = new Car(year, make);
            speedLabel.Text = newCar.Speed.ToString();
        }

        private void accelarateButton_Click(object sender, EventArgs e)
        {
            newCar.Accelerate();
            speedLabel.Text = newCar.Speed.ToString();
            speedLabel.ForeColor = Color.Green;
        }

        private void breakButton_Click(object sender, EventArgs e)
        {
            if (newCar.Speed >= 5)
            {
                newCar.Brake();
                speedLabel.Text = newCar.Speed.ToString();
                speedLabel.ForeColor = Color.Red;
            }
        }
    }
}
