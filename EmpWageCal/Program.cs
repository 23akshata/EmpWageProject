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
            CheckAttendances Amazon = new CheckAttendances("Amazon", 20, 2, 10);
            CheckAttendances Google = new CheckAttendances("Google", 10, 4, 20);
            Amazon.Attendances();
            Console.WriteLine(Amazon.ToString());
            Google.Attendances();
            Console.WriteLine(Google.ToString());
            Console.ReadLine();
        }
    }
}