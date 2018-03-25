using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    static public class Accounting
    {
        public enum Doctors // specialization - salary for HourPWeek
        {
            VENEREOLOGIST = 110,
            GASTROENTEROLOGIST = 130,
            GYNAECOLOGIST = 120,
            DERMATOLOGIST = 100,
            PEDIATRICIAN = 140,
            OPHTHALMOLOGIST = 90,
            ONCOLOGIST = 120,
            OTOLARYNGOLOGIST = 110,
            PSYCHIATRIST = 100,
            PULMONOLOGIST = 140,
            ROENTGENOLOGIST = 110,
            DENTIST = 105,
            PHYSICIAN = 120,
            UROLOGIST = 120,
            SURGEON = 90
        }

        static public double PayForOverTime { get; set; }
        static public double Premium { get; set; }
        static public double CalcHours (WorkTime[] hrs)
        {
            double dhrs = 0;

            foreach (WorkTime i in hrs)
            {
                dhrs += i.End.TimeOfDay.Hours - i.Begin.TimeOfDay.Hours;
            }
            
            return dhrs;
        }
    }
}
