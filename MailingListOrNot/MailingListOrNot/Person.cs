using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingListOrNot
{
    class Person
    {
        private string _name;
        private string _address;
        private string _telephone;

        public Person(string name, string address, string telephone)
        {
            _name = name;
            _address = address;
            _telephone = telephone;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Telephone
        {
            get { return _telephone; }
        }
    }
}
