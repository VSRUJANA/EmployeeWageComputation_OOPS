﻿using Employee_Wage_Computation_OOPS;
using System;
using System.Collections;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder : IComputeEmpWage
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int noOfCompanies = 0;
        public ArrayList CompanyEmpWageList = new ArrayList();
        public void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage c = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxWorkingHrs);
            CompanyEmpWageList.Insert(noOfCompanies, c);
            noOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpWage c = (CompanyEmpWage)CompanyEmpWageList[i];
                c.SetTotalEmpWage(this.EmployeeWageComputation(c));
                Console.WriteLine(c.Display());
            }
        }
        public int EmployeeWageComputation(CompanyEmpWage empwage)
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            int empHrs = 0;
            Random random = new Random();
            while (totalWorkingHrs <= empwage.maxWorkingHrs && totalWorkingDays < empwage.noOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalWorkingHrs += empHrs;
                int dailyWage = empHrs * empwage.empRatePerHr;
                Console.WriteLine("Day " + totalWorkingDays + " - Working Hours: " + empHrs + " - Daily wage: " + dailyWage );
               
            }
            monthlySalary = totalWorkingHrs * empwage.empRatePerHr;
            return monthlySalary;
        }
    }
}