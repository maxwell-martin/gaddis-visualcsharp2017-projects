using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<PhoneBookEntry> entries = new List<PhoneBookEntry>();

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile = File.OpenText("PhoneList.txt");

                PhoneBookEntry entry = new PhoneBookEntry();

                char[] delim = { ',' };

                string line;

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine().Trim();

                    string[] tokens = line.Split(delim);

                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    entries.Add(entry);
                }
            }
            catch
            {
                MessageBox.Show("The file is unreadable.");
            }
        }

        private void DisplayNames()
        {
            foreach (PhoneBookEntry person in entries)
            {
                nameListBox.Items.Add(person.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            phoneLabel.Text = entries[index].phone;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
