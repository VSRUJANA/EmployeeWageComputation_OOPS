using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            //1 => present and 0 => absent
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
