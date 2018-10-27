using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        private DateTime _maturityDate;

        public CDAccount()
        {
            _maturityDate = new DateTime();
        }

        public DateTime MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
