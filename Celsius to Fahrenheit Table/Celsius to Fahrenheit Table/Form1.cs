using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_to_Fahrenheit_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            const int MAX_CELSIUS = 20;

            double fahrenheitEquivalent;

            temperaturesListBox.Items.Add("Celsisus | Fahrenheit");

            //From internet, uses ListView control
            //Functions very similarly to the ListBox control
            //Creates two columns in the ListView; -2 is the width of the fahrenheit column
            temperaturesListView.Columns.Add("Celsius");
            temperaturesListView.Columns.Add("Fahrenheit", -2);

            for (int celsiusStart = 0; celsiusStart <= MAX_CELSIUS; celsiusStart++)
            {
                fahrenheitEquivalent = ((9.0 / 5.0) * celsiusStart) + 32.0;

                temperaturesListBox.Items.Add(celsiusStart + "*C | " + fahrenheitEquivalent + "*F");

                //From internet, for ListView control
                //Creates a new ListViewItem object called item
                //No exactly sure how it works, but the initial parameter is what appears
                //... in the first column.
                //The SubItems.Add is what appears in the second column
                //The last line adds the data to the Items property in the temperaturesListView control
                ListViewItem item = new ListViewItem(celsiusStart + "*C");
                item.SubItems.Add(fahrenheitEquivalent + "*F");
                temperaturesListView.Items.Add(item);
            }
        }
    }
}
