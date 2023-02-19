using System.Collections.Generic;
using System;

namespace EmpWageCal
{
    public class CheckAttendence
    {
        public string company;
        public int Wage_Per_Hour;
        public int Max_Working_Days;
        public int Max_Working_Hours;
        public int totalWage;

        public CheckAttendence(string company, int Wage_Per_Hour, int Max_Working_Days, int Max_Working_Hours)
        {
            this.company = company;
            this.Wage_Per_Hour = Wage_Per_Hour;
            this.Max_Working_Days = Max_Working_Days;
            this.Max_Working_Hours = Max_Working_Hours;
            this.totalWage = 0;
        }
    }
    public class EmpWageWorking
    {
        private List<CheckAttendence> companyEmpWageList;

        public EmpWageWorking()
        {
            this.companyEmpWageList = new List<CheckAttendence>();
        }

        public void AddCompanyEmpWage(string company, int Wage_Per_Hour, int Max_Working_Days, int Max_Working_Hours)
        {
            CheckAttendence companyEmpWage = new CheckAttendence(company, Wage_Per_Hour, Max_Working_Days, Max_Working_Hours);
            this.companyEmpWageList.Add(companyEmpWage);
        }

        public void ComputeEmployeeWage()
        {
            foreach (CheckAttendence companyEmpWage in companyEmpWageList)
            {
                int empHours = 0, empWage = 0, totalEmpHours = 0, totalWorkingDays = 0;

                while (totalEmpHours < companyEmpWage.Max_Working_Hours && totalWorkingDays < companyEmpWage.Max_Working_Days)
                {
                    totalWorkingDays++;

                    Random random = new Random();
                    int empCheck = random.Next(0, 3);

                    switch (empCheck)
                    {
                        case 1:
                            empHours = 4;
                            break;
                        case 2:
                            empHours = 8;
                            break;
                        default:
                            empHours = 0;
                            break;
                    }

                    totalEmpHours += empHours;
                    empWage = empHours * companyEmpWage.Wage_Per_Hour;
                }

                companyEmpWage.totalWage = empWage * totalWorkingDays;
                Console.WriteLine($"Total employee wage for company {companyEmpWage.company} is {companyEmpWage.totalWage}");
            }
        }
    }
}