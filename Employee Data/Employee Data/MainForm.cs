using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");

            Employee employee2 = new Employee("Mark Jones", 39119);
            employee2.Department = "IT";
            employee2.Position = "Programmer";

            Employee employee3 = new Employee();
            employee3.Name = "Joy Rogers";
            employee3.IdNumber = 81774;
            employee3.Department = "Manufacturing";
            employee3.Position = "Engineer";

            MessageBox.Show(employee1.Name + " " + employee1.IdNumber + " " + employee1.Department + " "
                + employee1.Position + "\n\n" + employee2.Name + " " + employee2.IdNumber + " " + 
                employee2.Department + " " + employee2.Position + "\n\n" + employee3.Name + " " + 
                employee3.IdNumber + " " + employee3.Department + " "+ employee3.Position + "\n\n");
        }
    }
}
