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
            const int MAX_HRS_PER_MONTH = 100;
            //variables
            int empHrs = 0;
            int empCheck = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            //Computation of monthly wage of employee
            while (totalEmpHrs <= MAX_HRS_PER_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Employee worked for " + empHrs + " hours on day " + totalWorkingDays);
            }
            int totalEmpWage = totalEmpHrs * WAGE_PER_HOUR;
            Console.WriteLine("Total employee wage for the month :" + totalEmpWage);
        }
    }
}
