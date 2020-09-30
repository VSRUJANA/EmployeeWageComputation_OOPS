using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                //Console.WriteLine("Employee worked for " + empHrs + " hours on day " + totalWorkingDays);
                Console.WriteLine("Day# " + totalWorkingDays + " - Emp Hours : " + empHrs);

            }
            return totalEmpHrs * WAGE_PER_HOUR;

        }
        static void Main(string[] args)
        {
            int totalEmpWage = ComputeEmpWage();
            Console.WriteLine("Total employee wage for the month :" + totalEmpWage);
        }

    }
}
