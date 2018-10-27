using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Information myself = new Information();
            myself.Name = "Max";
            myself.Address = "123 Lunar Street \n" +
                "Lunar Circle, Mars 99999";
            myself.Age = 20;
            myself.PhoneNumber = "777-777-7777";

            name1Label.Text = myself.Name;
            address1Label.Text = myself.Address;
            age1Label.Text = myself.Age.ToString();
            phoneNumber1Label.Text = myself.PhoneNumber;

            Information friend = new Information();
            friend.Name = "Nat";
            friend.Address = "122 Lunar Street \n" +
                "Lunar Circle, Mars 99999";
            friend.Age = 22;
            friend.PhoneNumber = "888-888-8888";

            name2Label.Text = friend.Name;
            address2Label.Text = friend.Address;
            age2Label.Text = friend.Age.ToString();
            phoneNumber2Label.Text = friend.PhoneNumber;

            Information familyMember = new Information();
            familyMember.Name = "Ethan";
            familyMember.Address = "123 Lunar Street \n" +
                "Lunar Circle, Mars 99999";
            familyMember.Age = 16;
            familyMember.PhoneNumber = "666-666-6666";

            name3Label.Text = familyMember.Name;
            address3Label.Text = familyMember.Address;
            age3Label.Text = familyMember.Age.ToString();
            phoneNumber3Label.Text = familyMember.PhoneNumber;
        }
    }
}
