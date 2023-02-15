using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Employee Wage Compution");
            Console.WriteLine("Enter The Company Name");
            string company = Console.ReadLine();
            Console.WriteLine("Enter The Rate Per Hrs");
            int empRatePrHrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Working Days");
            int numofWorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Maximum Hour Per Months");
            int numofWorkingHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            CheckAttendances Empcheck = new CheckAttendances();
            Empcheck.Attendances(company, empRatePrHrs, numofWorkingDays, numofWorkingHours);
            Console.ReadLine();
        }
    }
}