using System;

namespace Employee_Wage_Computation_OOPS
{
    class Program
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int CalculateWorkHrs()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int workHrs = 0;
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    workHrs = 8;
                    break;
                case IS_PART_TIME:
                    workHrs = 4;
                    break;
                default:
                    workHrs = 0;
                    break;
            }
            return workHrs;
        }
        public static void ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Console.WriteLine("Employee wage details of " + company + " : ");
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                empHrs = CalculateWorkHrs();
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# " + totalWorkingDays + " - Emp Hours : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee wage for company " + company + " is " + totalEmpWage +"\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!\n");
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }

    }
}