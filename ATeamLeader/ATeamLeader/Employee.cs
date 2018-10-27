using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATeamLeader
{
    class Employee
    {
        private string _name;
        private int _number;

        public Employee(string name, int number)
        {
            _name = name;
            _number = number;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Number
        {
            get { return _number; }
        }
    }
}
