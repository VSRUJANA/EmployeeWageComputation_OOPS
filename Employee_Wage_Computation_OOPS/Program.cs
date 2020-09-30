using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int WAGE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            //Computation of wage
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;  //Assuming part time hours as 4
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
