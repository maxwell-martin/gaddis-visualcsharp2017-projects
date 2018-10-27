using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingListOrNot
{
    class Customer : Person
    {
        private int _number;
        private bool _mailingList;

        public Customer(string name, string address, string telephone, int number, bool mailingList)
            : base(name, address, telephone)
        {
            _number = number;
            _mailingList = mailingList;
        }

        public int Number
        {
            get { return _number; }
        }

        public bool MailingList
        {
            get { return _mailingList; }
        }
    }
}
