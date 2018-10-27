using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATeamLeader
{
    class ProductionWorker : Employee
    {
        private int _shiftNumber;
        private decimal _hourlyPayRate;

        public ProductionWorker(string name, int number, int shiftNumber, decimal payRate) : base(name, number)
        {
            _shiftNumber = shiftNumber;
            _hourlyPayRate = payRate;
        }

        public int ShiftNumber
        {
            get { return _shiftNumber; }
        }

        public decimal HourlyPayRate
        {
            get { return _hourlyPayRate; }
        }
    }
}
