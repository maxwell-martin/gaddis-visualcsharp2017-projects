using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Information
{
    public partial class MainForm : Form
    {
        List<Pet> pets = new List<Pet>();
        int petAge;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool ValidInput()
        {
            bool isValid = false;

            if (nameTextBox.Text != "" && nameTextBox.Text != null && typeTextBox.Text != ""
                && typeTextBox.Text != null && int.TryParse(ageTextBox.Text, out petAge) && petAge >= 0)
            {
                isValid = true;
            }

            return isValid;
        }

        private bool ExistsAlready()
        {
            bool found = false;
            int index = 0;

            while (!found && index < pets.Count)
            {
                if (pets[index].Name == nameTextBox.Text && pets[index].Type == typeTextBox.Text
                        && pets[index].Age == petAge)
                {
                    found = true;
                }

                index++;
            }

            return found;
        }

        private void Clear()
        {
            nameTextBox.Clear();
            typeTextBox.Clear();
            ageTextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                Pet newPet = new Pet(nameTextBox.Text, typeTextBox.Text, petAge);

                if (petsListBox.Items.Count == 0)
                {
                    petsListBox.Items.Add(newPet.Name);
                    pets.Add(newPet);
                    Clear();
                    nameTextBox.Focus();
                }
                else
                {
                    if (!ExistsAlready())
                    {
                        petsListBox.Items.Add(newPet.Name);
                        pets.Add(newPet);
                        Clear();
                        nameTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show(newPet.Name + " the " + newPet.Type + " already exists.");
                        Clear();
                        nameTextBox.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
                Clear();
                nameTextBox.Focus();
            }
        }

        private void petsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = petsListBox.SelectedIndex;

            PetInformationForm petInfo = new PetInformationForm();
            petInfo.nameLabel.Text = pets[selectedIndex].Name;
            petInfo.typeLabel.Text = pets[selectedIndex].Type;
            petInfo.ageLabel.Text = pets[selectedIndex].Age.ToString();

            petInfo.ShowDialog();
            nameTextBox.Focus();
        }
    }
}
