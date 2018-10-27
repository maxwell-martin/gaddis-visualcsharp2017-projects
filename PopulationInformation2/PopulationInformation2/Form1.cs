using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopulationInformation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void city3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.city3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City3' table. You can move, or remove it, as needed.
            this.city3TableAdapter.Fill(this.populationDataSet.City3);
        }

        private void sortAscPopulation_Click(object sender, EventArgs e)
        {
            this.city3TableAdapter.SortByPopulationAsc(this.populationDataSet.City3);
        }

        private void sortDescPopulation_Click(object sender, EventArgs e)
        {
            this.city3TableAdapter.SortByPopulationDesc(this.populationDataSet.City3);
        }

        private void sortNameButton_Click(object sender, EventArgs e)
        {
            this.city3TableAdapter.SortByName(this.populationDataSet.City3);
        }

        private void totalPopulationButton_Click(object sender, EventArgs e)
        {
            int totalPopulation = (int) this.city3TableAdapter.TotalPopulation();
            MessageBox.Show("The total population of all cities is: " + totalPopulation);
        }

        private void avgPopulationButton_Click(object sender, EventArgs e)
        {
            int averagePopulation = (int) this.city3TableAdapter.AveragePopulation();
            MessageBox.Show("The average population of all cities is: " + averagePopulation);
        }

        private void maxPopulationButton_Click(object sender, EventArgs e)
        {
            int highestPopulation = (int) this.city3TableAdapter.MaxPopulation();
            MessageBox.Show("The highest population of all cities is: " + highestPopulation);
        }

        private void minPopulationButton_Click(object sender, EventArgs e)
        {
            int lowestPopulation = (int) this.city3TableAdapter.MinPopulation();
            MessageBox.Show("The lowest population of all cities is: " + lowestPopulation);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.city3TableAdapter.Fill(this.populationDataSet.City3);
        }
    }
}
