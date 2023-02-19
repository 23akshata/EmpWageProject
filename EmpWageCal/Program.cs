using EmpWageCal;
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
            Console.WriteLine("Employee Wage of multiple companies");
            EmpWageWorking empWageWorking = new EmpWageWorking();
            empWageWorking.AddCompanyEmpWage("Amazon", 20, 20, 100);
            empWageWorking.AddCompanyEmpWage("Google", 25, 25, 120);
            empWageWorking.ComputeEmployeeWage();
            Console.ReadLine();
        }
    }
}