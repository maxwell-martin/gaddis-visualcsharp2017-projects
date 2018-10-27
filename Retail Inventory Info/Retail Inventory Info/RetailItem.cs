using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Inventory_Info
{
    class RetailItem
    {
        private string _description;
        private int _units;
        private decimal _price;

        public RetailItem(string description, int units, decimal price)
        {
            _description = description;
            _units = units;
            _price = price;
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int UnitsOnHand
        {
            get { return _units; }
            set { _units = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
