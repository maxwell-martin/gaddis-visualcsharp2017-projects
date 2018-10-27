using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        private string _brand;
        private string _model;
        private decimal _price;

        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
