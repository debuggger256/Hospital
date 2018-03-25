using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public abstract class Person
    {
        private int _age;

        public Person(string fname, string lname, DateTime dateBirth, bool sex)
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dateBirth;
            Sex = sex;
            _age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateTime.Today.Month > DateOfBirth.Month) _age++;
            else if (DateTime.Today.Month == DateOfBirth.Month
                && DateTime.Today.Day >= DateOfBirth.Day) _age++;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Sex { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}