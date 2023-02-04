using System;

namespace Empoyee_wage2
{
    internal class Program
    {
        public class EmployeeCheck
        {
            public const int partTime = 1;
            public const int fullTime = 2;
            public const int PerHour = 20;
            public static void CheckAttendence()
            {

                int empHrs = 0;
                int empWage = 0;

                Random random = new Random();
                int empCheck = random.Next(2);

                switch (empCheck)
                {
                    case partTime:
                        empHrs = 4;
                        break;
                    case fullTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * PerHour;
                Console.WriteLine("Employee Wage: " + empWage);
            }
        }
    }
}



