using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCal
{
    public class CheckAttendances
    {
        public void Attendances()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HRS = 20;
            const int WORKING_DAYS = 20;
            int empHrs = 0;
            int empWages = 0; int totalEmpWage = 0;
            for (int day = 0; day < WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee Is Present Full Time");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee Is Present Part Time ");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWages = EMP_RATE_PER_HRS * empHrs;
                totalEmpWage = totalEmpWage + empWages;
                Console.WriteLine("empWages = " + empWages);
            }
            Console.WriteLine("total emp wage : " + totalEmpWage);
        }
    }
}
