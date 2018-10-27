using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Information
{
    class Pet
    {
        private string _name;
        private string _type;
        private int _age;

        public Pet(string name, string type, int age)
        {
            _name = name;
            _type = type;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
