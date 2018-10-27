using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    class PreferredCustomer : Customer
    {
        private decimal _totalPurchases;
        private decimal _discountLevel;

        public PreferredCustomer(string name, string address, string telephone, int number, decimal totalPurchases)
            : base(name, address, telephone, number)
        {
            _totalPurchases = totalPurchases;
            _discountLevel = 0m;
        }

        public decimal TotalPurchase
        {
            get { return _totalPurchases; }
            set { _totalPurchases = value; }
        }

        public decimal DiscountLevel
        {
            get { return _discountLevel; }
            set { _discountLevel = value; }
        }
    }
}
