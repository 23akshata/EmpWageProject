using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Employee Compution ");
            CheckAttendances EmpCheck = new CheckAttendances();
            EmpCheck.Attendances();
            Console.ReadLine();
        }
    }
}