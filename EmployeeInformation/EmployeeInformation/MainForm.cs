using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm();
            details.ShowDialog();
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void sortAscButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SortByPayAscending(this.employeeDataSet.Employee);
        }

        private void sortDescButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SortByPayDescending(this.employeeDataSet.Employee);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchTextBox.Text;
            this.employeeTableAdapter.SearchByName(this.employeeDataSet.Employee, name);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void highestPayRateButton_Click(object sender, EventArgs e)
        {
            decimal highestPayRate;
            highestPayRate = (decimal) this.employeeTableAdapter.MaxPayRate();
            MessageBox.Show("The highest pay rate is: " + highestPayRate.ToString("c") + " per hour.");
        }

        private void lowestPayRateButton_Click(object sender, EventArgs e)
        {
            decimal lowestPayRate;
            lowestPayRate = (decimal) this.employeeTableAdapter.MinPayRate();
            MessageBox.Show("The lowest pay rate is: " + lowestPayRate.ToString("c") + " per hour.");
        }
    }
}
