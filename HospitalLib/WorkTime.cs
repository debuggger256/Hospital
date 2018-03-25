using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public struct WorkTime
    {
        private int _hours;
        private DateTime _begin;
        private DateTime _end;

        public WorkTime (DateTime beg, DateTime end)
        {
            _begin = beg;
            _end = end;
            _hours = _end.TimeOfDay.Hours - _begin.TimeOfDay.Hours;
        }

        public DateTime Begin
        {
            get { return _begin; }
            set { _begin = value; _hours = _end.TimeOfDay.Hours - _begin.TimeOfDay.Hours; }
        }
        public DateTime End
        {
            get { return _end; }
            set { _end = value; _hours = _end.TimeOfDay.Hours - _begin.TimeOfDay.Hours; }
        }
        public int Hours { get { return _hours; } }
    }
}
