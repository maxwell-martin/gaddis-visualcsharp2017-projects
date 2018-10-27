using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        List<CellPhone> phoneList = new List<CellPhone>();

        decimal price;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsInputValid()
        {
            string brand = brandTextBox.Text;
            string model = modelTextBox.Text;

            bool isValid = false;

            if (brand != "" && brand != null && model != "" && model != null
                && decimal.TryParse(priceTextBox.Text, out price) && price > 0m)
            {
                isValid = true;
            }

            return isValid;
        }

        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            phone.Price = price;
        }

        private bool IsDuplicateEntry(CellPhone phone)
        {
            bool isDuplicate = false;
            int index = 0;

            if (phoneList.Count != 0)
            {
                while (!isDuplicate && index < phoneList.Count)
                {
                    if (phoneList[index].Brand == phone.Brand && phoneList[index].Model == phone.Model
                        && phoneList[index].Price == phone.Price)
                    {
                        isDuplicate = true;
                    }

                    index++;
                }
            }

            return isDuplicate;
        }

        private void DisplayPhoneData(CellPhone phone)
        {
            phoneList.Add(phone);
            phoneListBox.Items.Add(phone.Brand + " " + phone.Model);
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                CellPhone phone = new CellPhone();

                GetPhoneData(phone);

                if (!IsDuplicateEntry(phone))
                {
                    DisplayPhoneData(phone);
                }
                else
                {
                    MessageBox.Show("Phone already exists.");
                    Clear();
                    brandTextBox.Focus();
                }

                Clear();
                brandTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please make sure all textboxes are filled in and contain valid input.");
                Clear();
                brandTextBox.Focus();
            }
        }

        private void Clear()
        {
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = phoneListBox.SelectedIndex;
            MessageBox.Show(phoneList[selectedIndex].Price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
