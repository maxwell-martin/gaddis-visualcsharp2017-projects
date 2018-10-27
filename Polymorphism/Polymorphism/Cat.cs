using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    class Cat : Animal
    {
        private string _name;

        public Cat(string name) : base("Cat")
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }
    }
}
