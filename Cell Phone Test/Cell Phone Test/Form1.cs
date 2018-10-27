using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool InputExists()
        {
            bool isValid = false;

            if (brandTextBox.Text != "" && modelTextBox.Text != "" && priceTextBox.Text != "")
                if (brandTextBox.Text != null && modelTextBox.Text != null && priceTextBox.Text != null)
                    isValid = true;

            return isValid;
        }

        private bool GetPhoneData(CellPhone phone)
        {
            bool isValid = false;

            decimal price;

            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            if (decimal.TryParse(priceTextBox.Text, out price) && price >= 0m)
            {
                phone.Price = price;
                isValid = true;
            }
            else
            {
                MessageBox.Show("Price is invalid.");
                priceTextBox.Clear();
                priceTextBox.Focus();
            }

            return isValid;
        }

        private void DisplayPhoneData(CellPhone phone)
        {
            brandLabel.Text = phone.Brand;
            modelLabel.Text = phone.Model;
            priceLabel.Text = phone.Price.ToString("c");
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();

            if (InputExists())
            {
                if (GetPhoneData(phone))
                {
                    DisplayPhoneData(phone);
                }
            }
            else
            {
                MessageBox.Show("Please make sure all textboxes are filled.");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
