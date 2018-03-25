using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class Doctor : Employee
    {
        private WorkTime[] _workTime; // schedule
        private DateTime _start; // in real
        private DateTime _end; 

        public Doctor(string fname, string lname, DateTime dateBirth,
            bool sex, Accounting.Doctors s, WorkTime[] wTime) :
            base(fname, lname, dateBirth, sex, s, Accounting.CalcHours(wTime))
        {
            _workTime = wTime;
        }

        public WorkTime[] Work
        {
            get { return _workTime; }
            set
            {
                _workTime = value;
                _hoursPWeek = Accounting.CalcHours(_workTime);
            }
        }
        public int room { get; set; }
        public void startWork()
        {
            _start = DateTime.Now;
        }
        public void endWork()
        {
            _end = DateTime.Now;
            WorkTime t = new WorkTime(_start, _end);
            WorkTime today = new WorkTime();
            foreach (WorkTime i in Work)
            {
                if (i.Begin.DayOfWeek == DateTime.Now.DayOfWeek) // now day in schedule
                {
                    today = i;
                    break;
                }
            }
            if (today.Hours != 0)
            {
                if (t.Hours > today.Hours)
                    _overTimeHours += t.Hours - today.Hours;
                else
                    _overTimeHours -= today.Hours - t.Hours;
            }
        }
    }
}