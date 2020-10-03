using Employee_Wage_Computation_OOPS;
using System;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int noOfCompanies = 0;
        CompanyEmpWage[] CompanyEmpWageArray;
        public EmployeeWageBuilder()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[10];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWageArray[noOfCompanies] = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxWorkingHrs);
            noOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpWageArray[i].SetTotalEmpWage(this.EmployeeWageComputation(this.CompanyEmpWageArray[i]));
                Console.WriteLine(CompanyEmpWageArray[i].Display());
            }
        }
        static int EmployeeHours(int empCheck)
        {
            int empHrs = 0;
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
            return empHrs;
        }
        public int EmployeeWageComputation(CompanyEmpWage empwage)
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            Console.WriteLine("\n");
            while (totalWorkingHrs <= empwage.maxWorkingHrs && totalWorkingDays < empwage.noOfWorkingDays)
            {
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                int empHrs = EmployeeHours(empCheck);
                totalWorkingHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " - Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * empwage.empRatePerHr;
            return monthlySalary;
        }
    }
}