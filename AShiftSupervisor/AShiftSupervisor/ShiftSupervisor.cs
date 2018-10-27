using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShiftSupervisor
{
    class ShiftSupervisor : Employee
    {
        private const decimal BONUS_PERCENT = 0.02m;

        private decimal _salary;
        private decimal _bonusPercent;

        public ShiftSupervisor(string name, int number, decimal salary) : base(name, number)
        {
            _salary = salary;
            _bonusPercent = BONUS_PERCENT;
        }

        public decimal Salary
        {
            get { return _salary; }
        }

        public decimal Bonus
        {
            get { return _bonusPercent * _salary; }
        }
    }
}
