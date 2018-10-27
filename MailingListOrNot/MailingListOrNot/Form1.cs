using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingListOrNot
{
    public partial class Form1 : Form
    {
        private string name;
        private string address;
        private string telephone;
        private int customerNumber;
        private bool mailingListStatus = false;

        public Form1()
        {
            InitializeComponent();
        }

        public bool IsInputValid()
        {
            bool valid = false;

            if (!string.IsNullOrEmpty(nameTB.Text) && !string.IsNullOrWhiteSpace(nameTB.Text))
            {
                name = nameTB.Text;

                if (!string.IsNullOrEmpty(addressTB.Text) && !string.IsNullOrWhiteSpace(addressTB.Text))
                {
                    address = addressTB.Text;

                    if (!string.IsNullOrEmpty(telephoneTB.Text) && !string.IsNullOrWhiteSpace(telephoneTB.Text)
                        && telephoneTB.Text[0] == '(' && telephoneTB.Text[4] == ')' && telephoneTB.Text[8] == '-' 
                        && telephoneTB.Text.Length == 13)
                    {
                        telephone = telephoneTB.Text;

                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("Phone number is invalid (Format -> (###)###-####).");
                        telephoneTB.Clear();
                        telephoneTB.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Address is invalid.");
                    addressTB.Clear();
                    addressTB.Focus();
                }
            }
            else
            {
                MessageBox.Show("Name is invalid.");
                nameTB.Clear();
                nameTB.Focus();
            }

            return valid;
        }

        private void ClearAll()
        {
            nameTB.Clear();
            addressTB.Clear();
            telephoneTB.Clear();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (IsInputValid())
            {
                customerNumber = rand.Next();

                if (mailingListCheckBox.Checked)
                {
                    mailingListStatus = true;

                    Customer theCustomer = new Customer(name, address, telephone, customerNumber, mailingListStatus);

                    MessageBox.Show("You have successfully signed up.\n\nName: " + theCustomer.Name + "\n\nAddress: " + 
                        theCustomer.Address + "\n\nPhone Number: " + theCustomer.Telephone + "\n\nMailing List Subscription: YES");

                    ClearAll();
                    nameTB.Focus();
                }
                else
                {
                    Customer theCustomer = new Customer(name, address, telephone, customerNumber, mailingListStatus);

                    MessageBox.Show("You have successfully signed up.\n\nName: " + theCustomer.Name + "\n\nAddress: " +
                        theCustomer.Address + "\n\nPhone Number: " + theCustomer.Telephone + "\n\nMailing List Subscription: NO");
                    ClearAll();
                    nameTB.Focus();
                }
            }
        }
    }
}
