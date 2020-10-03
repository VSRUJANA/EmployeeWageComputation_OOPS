﻿using System;

namespace Employee_Wage_Computation_OOPS
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs);
        void ComputeEmpWage();
        int EmployeeWageComputation(CompanyEmpWage empwage);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int noOfWorkingDays;
        public int maxWorkingHrs;
        public int empRatePerHr;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string Display()
        {
            return "Total employee wage for company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
