using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class CheckAttendances
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public int Attendances(string company, int empRatePrHrs, int numofWorkingDays, int numofWorkingHours)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= numofWorkingHours && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePrHrs;
            Console.WriteLine("total emp wage : " + totalEmpWage);
            return totalEmpWage;
        }

    }

}