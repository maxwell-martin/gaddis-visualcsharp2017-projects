using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        /* Initializes three variables for the three different seat types 
        and assigns them their constant price. */
        const double CLASS_A_PRICE = 15.0;
        const double CLASS_B_PRICE = 12.0;
        const double CLASS_C_PRICE = 9.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /* Setups up a try-catch exception handler that displays a default 
            error message if the user enters in incorrect input. */
            try
            {
                /* Initializes three variables for the number of each seat type sold and 
                assigns their value to the corresponding input that the user enters. */
                double numberOfClassASold = double.Parse(a_TextBox.Text);
                double numberOfClassBSold = double.Parse(b_TextBox.Text);
                double numberOfClassCSold = double.Parse(c_TextBox.Text);

                /* Initializes a variable for the amount of revenue generated from Class A tickets and
                assigns it to the number of Class A tickets sold multiplied by the Class A ticket price.
                * Then, the text of the "a_Label" is assigned to the amount of revenue generated from 
                Class A tickets (a string in currency format is displayed). */
                double revenue_ClassA = numberOfClassASold * CLASS_A_PRICE;
                a_Label.Text = revenue_ClassA.ToString("c");

                /* Initializes a variable for the amount of revenue generated from Class B tickets and
                assigns it to the number of Class B tickets sold multiplied by the Class B ticket price.
                * Then, the text of the "b_Label" is assigned to the amount of revenue generated from 
                Class B tickets (a string in currency format is displayed). */
                double revenue_ClassB = numberOfClassBSold * CLASS_B_PRICE;
                b_Label.Text = revenue_ClassB.ToString("c");

                /* Initializes a variable for the amount of revenue generated from Class C tickets and
                assigns it to the number of Class C tickets sold multiplied by the Class C ticket price.
                * Then, the text of the "c_Label" is assigned to the amount of revenue generated from 
                Class C tickets (a string in currency format is displayed). */
                double revenue_ClassC = numberOfClassCSold * CLASS_C_PRICE;
                c_Label.Text = revenue_ClassC.ToString("c");

                /* Initializes a variable for the total revenue generated and assigns it to the revenue
                generated when adding up all three revenue values from each ticket class.
                * Then, the text of the "totalLabel" is assigned to the total revenue generated 
                (a string in currency format is displayed). */
                double totalRevenue = revenue_ClassA + revenue_ClassB + revenue_ClassC;
                totalLabel.Text = totalRevenue.ToString("c");

                // Focuses the cursor on the clear button.
                clearButton.Focus();
            }
            catch (Exception ex)
            {
                // Displays the default Exception Handler error message.
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            // Assigns specific label and textbox text values to blank.
            a_Label.Text = "";
            b_Label.Text = "";
            c_Label.Text = "";
            a_TextBox.Text = "";
            b_TextBox.Text = "";
            c_TextBox.Text = "";
            totalLabel.Text = "";

            // Focuses the cursor on the Class A textbox.
            a_TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program.
            this.Close();
        }
    }
}
