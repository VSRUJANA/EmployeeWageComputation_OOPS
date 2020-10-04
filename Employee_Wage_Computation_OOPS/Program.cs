using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!\n");
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
        }
    }
}