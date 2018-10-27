using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    class CompSciStudent : Student
    {
        private const double MATH_HOURS = 20;
        private const double CS_HOURS = 40;
        private const double GEN_HOURS = 60;

        private string _academicTrack;

        public CompSciStudent(string name, string id, string track) : base(name, id)
        {
            _academicTrack = track;
        }

        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
