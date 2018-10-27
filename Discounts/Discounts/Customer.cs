using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    class Customer : Person
    {
        private int _number;

        public Customer(string name, string address, string telephone, int number)
            : base(name, address, telephone)
        {
            _number = number;
        }

        public Customer()
        {
            _number = 0;
        }

        public int Number
        {
            get { return _number; }
        }
    }
}
