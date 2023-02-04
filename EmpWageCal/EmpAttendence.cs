using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCal
{
    public class CheckAttendances
    {
        public void Attendances ()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HRS = 20;
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWages = EMP_RATE_PER_HRS * empHrs;
            Console.WriteLine("empWages = " + empWages);
        }
    }
}
