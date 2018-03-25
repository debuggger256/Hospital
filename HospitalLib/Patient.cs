using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class Patient : Person
    {
        Patient(string fname, string lname, DateTime dateBirth, bool sex, bool onTheList) :
            base(fname, lname, dateBirth, sex)
        {
            OnTheList = onTheList;
        }

        public bool OnTheList { get; set; }
        public Doctor Therapist { get; set; }
    }
}