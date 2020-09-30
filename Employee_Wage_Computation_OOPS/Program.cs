using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            //variables
            int empHrs = 0;
            int empCheck = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //Computation of monthly wage of employee
            for (int day = 1; day < NUM_OF_WORKING_DAYS + 1; day++)
            {
                Random random = new Random();
                empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * WAGE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage for day " + day + ":" + empWage);
            }
            Console.WriteLine("Monthly wage of the employee:" + totalEmpWage);
        }
    }
}
