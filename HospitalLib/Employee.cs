using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public abstract class Employee : Person
    {
        private Accounting.Doctors _specialization;
        private double _salary;
        protected double _hoursPWeek;
        protected bool _HasPremium = false;
        protected int _overTimeHours = 0;

        public Employee(string fname, string lname, DateTime dateBirth,
            bool sex, Accounting.Doctors specialization, double hpw/*Hours p week*/) :
            base(fname, lname, dateBirth, sex)
        {
            _hoursPWeek = hpw;
            _specialization = specialization;
            _salary = hpw * (int)specialization;
        }
        public Employee(string fname, string lname, DateTime dateBirth,
           bool sex, Accounting.Doctors specialization) :
           base(fname, lname, dateBirth, sex)
        {
            _specialization = specialization;
        }

        public double Salary
        {
            get { return _salary; }
        }
        public Accounting.Doctors Specialization
        {
            get { return _specialization; }
        }
        public double HoursPWeek
        {
            get { return _hoursPWeek; }
        }
    }
}
