using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Inventory_Info
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            RetailItem[] inventory = { new RetailItem("Jacket", 12, 59.95m), new RetailItem("Jeans", 40, 34.95m),
                                        new RetailItem("Shirt", 20, 24.95m) };

            foreach(RetailItem item in inventory)
            {
                MessageBox.Show("Item 1:\n\n" + "Description\tUnits on Hand\tPrice\n\n" +
                    item.Description + "\t\t" + item.UnitsOnHand + "\t\t" + item.Price.ToString("c"));
            }
        }
    }
}
