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
        private string company;
        private int Emp_Rate_PrHrs;
        private int Num_of_Working_Days;
        private int Max_Rate_In_Month;
        private int totalEmpWage;
        public CheckAttendances(string company, int Emp_Rate_PrHrs, int Num_of_Working_Days, int Max_Rate_In_Month)
        {
            this.company = company;
            this.Emp_Rate_PrHrs = Emp_Rate_PrHrs;
            this.Num_of_Working_Days = Num_of_Working_Days;
            this.Max_Rate_In_Month = Max_Rate_In_Month;

        }

        public void Attendances()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Rate_In_Month && totalWorkingDays < Max_Rate_In_Month)
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
            int totalEmpWage = totalEmpHrs * this.Emp_Rate_PrHrs;
            Console.WriteLine("total emp wage : " + company + " is" + totalEmpWage);

        }
        public string tostring()
        {
            return "Total Wage For Company " + this.company + "is" + totalEmpWage;
        }

    }

}