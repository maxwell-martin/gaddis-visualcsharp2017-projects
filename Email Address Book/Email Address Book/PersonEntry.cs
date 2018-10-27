using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Address_Book
{
    class PersonEntry
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public PersonEntry()
        {
            _name = "";
            _email = "";
            _phoneNumber = "";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

    }
}
