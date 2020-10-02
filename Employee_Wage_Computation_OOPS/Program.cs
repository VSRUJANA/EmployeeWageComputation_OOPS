using System;

namespace Employee_Wage_Computation_OOPS
{
    class EmployeeWageBuilder
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        //variables
        string company;
        int noOfWorkingDays;
        int maxWorkingHrs;
        int empRatePerHr;
        public EmployeeWageBuilder(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
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
        public int ComputeEmpWage()
        {
            //variables
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            Console.WriteLine("\nCompany: " + company);
            Random random = new Random();
            while (totalWorkingHrs <= maxWorkingHrs && totalWorkingDays < noOfWorkingDays)
            {
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                int empHrs = CalculateWorkHrs();
                totalWorkingHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " - Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * empRatePerHr;
            return monthlySalary;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            EmployeeWageBuilder dmart = new EmployeeWageBuilder("DMart", 20, 2, 10);
            Console.WriteLine("Total wage for DMart : " + dmart.ComputeEmpWage());
            EmployeeWageBuilder reliance = new EmployeeWageBuilder("Reliance", 10, 4, 20);
            Console.WriteLine("Total wage for Reliance : " + reliance.ComputeEmpWage());
        }

    }
}