using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Game
{
    class Car
    {
        private int _year;
        private string _make;
        private int _speed;

        public Car(int year, string make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void Accelerate()
        {
            _speed += 5;
        }

        public void Brake()
        {
            _speed -= 5;
        }
    }
}
