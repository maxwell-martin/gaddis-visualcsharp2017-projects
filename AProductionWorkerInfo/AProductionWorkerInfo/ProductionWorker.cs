using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProductionWorkerInfo
{
    class ProductionWorker : Employee
    {
        private int _shiftNumber;
        private double _hourlyPayRate;

        public ProductionWorker(string name, int number, int shiftNumber, double payRate) : base(name, number)
        {
            _shiftNumber = shiftNumber;
            _hourlyPayRate = payRate;
        }

        public int ShiftNumber
        {
            get { return _shiftNumber; }
        }

        public double HourlyPayRate
        {
            get { return _hourlyPayRate; }
        }
    }
}
