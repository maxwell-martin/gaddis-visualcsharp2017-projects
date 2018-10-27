using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine_Simulator
{
    struct Soda
    {
        public string drinkName;
        public double drinkCost;
        public int numberOfDrinksInMachine;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int TOTAL_PER_DRINK = 20;
        private const int MAX_DRINKS = 5;

        Soda[] listOfSodas = new Soda[MAX_DRINKS];

        double totalSales = 0.00;

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            if (listOfSodas[0].numberOfDrinksInMachine > 0)
            {
                totalSales += listOfSodas[0].drinkCost;
                listOfSodas[0].numberOfDrinksInMachine -= 1;

                totalSalesLabel.Text = "$" + totalSales.ToString("n2");
                colaQuantityLabel.Text = listOfSodas[0].numberOfDrinksInMachine.ToString();
            }
            else
            {
                MessageBox.Show("Sorry. We are out of " + listOfSodas[0].drinkName + ".");
            }
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            if (listOfSodas[1].numberOfDrinksInMachine > 0)
            {
                totalSales += listOfSodas[1].drinkCost;
                listOfSodas[1].numberOfDrinksInMachine -= 1;

                totalSalesLabel.Text = "$" + totalSales.ToString("n2");
                rootBeerQuantityLabel.Text = listOfSodas[1].numberOfDrinksInMachine.ToString();
            }
            else
            {
                MessageBox.Show("Sorry. We are out of " + listOfSodas[1].drinkName + ".");
            }
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            if (listOfSodas[2].numberOfDrinksInMachine > 0)
            {
                totalSales += listOfSodas[2].drinkCost;
                listOfSodas[2].numberOfDrinksInMachine -= 1;

                totalSalesLabel.Text = "$" + totalSales.ToString("n2");
                lemonLimeQuantityLabel.Text = listOfSodas[2].numberOfDrinksInMachine.ToString();
            }
            else
            {
                MessageBox.Show("Sorry. We are out of " + listOfSodas[2].drinkName + ".");
            }
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            if (listOfSodas[3].numberOfDrinksInMachine > 0)
            {
                totalSales += listOfSodas[3].drinkCost;
                listOfSodas[3].numberOfDrinksInMachine -= 1;

                totalSalesLabel.Text = "$" + totalSales.ToString("n2");
                grapeSodaQuantityLabel.Text = listOfSodas[3].numberOfDrinksInMachine.ToString();
            }
            else
            {
                MessageBox.Show("Sorry. We are out of " + listOfSodas[3].drinkName + ".");
            }
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            if (listOfSodas[4].numberOfDrinksInMachine > 0)
            {
                totalSales += listOfSodas[4].drinkCost;
                listOfSodas[4].numberOfDrinksInMachine -= 1;

                totalSalesLabel.Text = "$" + totalSales.ToString("n2");
                creamSodaQuantityLabel.Text = listOfSodas[4].numberOfDrinksInMachine.ToString();
            }
            else
            {
                MessageBox.Show("Sorry. We are out of " + listOfSodas[4].drinkName + ".");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Soda cola = new Soda();
            Soda rootBeer = new Soda();
            Soda lemonLime = new Soda();
            Soda grapeSoda = new Soda();
            Soda creamSoda = new Soda();

            cola.drinkName = "Cola";
            cola.drinkCost = 1.00;
            cola.numberOfDrinksInMachine = TOTAL_PER_DRINK;

            rootBeer.drinkName = "Root Beer";
            rootBeer.drinkCost = 1.00;
            rootBeer.numberOfDrinksInMachine = TOTAL_PER_DRINK;

            lemonLime.drinkName = "Lemon Lime";
            lemonLime.drinkCost = 1.00;
            lemonLime.numberOfDrinksInMachine = TOTAL_PER_DRINK;

            grapeSoda.drinkName = "Grape Soda";
            grapeSoda.drinkCost = 1.50;
            grapeSoda.numberOfDrinksInMachine = TOTAL_PER_DRINK;

            creamSoda.drinkName = "Cream Soda";
            creamSoda.drinkCost = 1.50;
            creamSoda.numberOfDrinksInMachine = TOTAL_PER_DRINK;

            listOfSodas[0] = cola;
            listOfSodas[1] = rootBeer;
            listOfSodas[2] = lemonLime;
            listOfSodas[3] = grapeSoda;
            listOfSodas[4] = creamSoda;
        }
    }
}
