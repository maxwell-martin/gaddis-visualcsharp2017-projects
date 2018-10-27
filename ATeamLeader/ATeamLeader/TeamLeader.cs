using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATeamLeader
{
    class TeamLeader : ProductionWorker
    {
        private const int REQUIRED_TRAINING_HOURS = 50;

        private decimal _monthlyBonusPercent;
        private int _trainingHoursAttended;

        public TeamLeader(string name, int number, int shiftNumber, decimal hourlyRate, int trainingHoursAttended) 
            : base(name, number, shiftNumber, hourlyRate)
        {
            _monthlyBonusPercent = 0.01m;
            _trainingHoursAttended = trainingHoursAttended;
        }

        public decimal MonthlyBonusAmt
        {
            get { return _monthlyBonusPercent * (HourlyPayRate * 4); }
        }

        public int RequiredTrainingHours
        {
            get { return REQUIRED_TRAINING_HOURS; }
        }

        public int TrainingHoursAttended
        {
            get { return _trainingHoursAttended; }
        }

        public bool AttendedEnoughTraining(int trainingHoursAttended)
        {
            if (trainingHoursAttended >= REQUIRED_TRAINING_HOURS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
