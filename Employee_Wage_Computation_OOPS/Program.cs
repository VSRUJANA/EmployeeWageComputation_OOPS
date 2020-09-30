using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1;
            int WAGE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            //Computation of wage
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                empHrs = 8;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee wage :" + empWage);
        }
    }
}
