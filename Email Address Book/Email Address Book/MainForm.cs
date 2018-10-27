using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Email_Address_Book
{
    public partial class MainForm : Form
    {
        private List<PersonEntry> contactList = new List<PersonEntry>();
        private List<string> contactListNames = new List<string>();

        private InformationForm personInfo = new InformationForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            phoneNumber = "(" + phoneNumber.Substring(0, 3) + ")" + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6);

            return phoneNumber;
        }

        private int SequentialSearch(List<PersonEntry> inputList, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < inputList.Count)
            {
                if (inputList[index].Name == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            return position;
        }

        private void RemoveDuplicates(List<PersonEntry> inputList)
        {
            int index = 0;

            while (index < inputList.Count)
            {
                inputList.RemoveAt(inputList.LastIndexOf(inputList[index]));
                index++;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile = File.OpenText("Contacts.txt");

                while (!inputFile.EndOfStream)
                {
                    PersonEntry person = new PersonEntry();

                    person.Name = inputFile.ReadLine();
                    person.Email = inputFile.ReadLine();
                    person.PhoneNumber = FormatPhoneNumber(inputFile.ReadLine());

                    contactList.Add(person);
                    contactListNames.Add(person.Name);
                }

                contactListNames.Sort();

                int x = 0;

                while (x < contactListNames.Count)
                {
                    contactList.Insert(x, contactList[SequentialSearch(contactList, contactListNames[x])]);
                    contactsListBox.Items.Add(contactList[x].Name);
                    x++;
                }

                RemoveDuplicates(contactList);
            }
            catch
            {
                MessageBox.Show("File unreadable.");
            }
        }

        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personInfo.nameLabel.Text = contactList[contactsListBox.SelectedIndex].Name;
            personInfo.emailLabel.Text = contactList[contactsListBox.SelectedIndex].Email;
            personInfo.phoneNumberLabel.Text = contactList[contactsListBox.SelectedIndex].PhoneNumber;
            personInfo.ShowDialog();
        }
    }
}
