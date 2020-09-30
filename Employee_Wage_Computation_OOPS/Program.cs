using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            const int WAGE_PER_HOUR = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //switch case to calculate part time wages
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
            Console.WriteLine("Employee wage :" + empWage);
        }
    }
}
