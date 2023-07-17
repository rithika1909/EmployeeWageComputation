using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyWage
    {
        const int FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1;
        int totalEmpWage = 0, empHrs = 0, wagePerHr, totalWorkingDays, totalWorkingHrs;
        string companyName;
        Random random = new Random();
        public Employee(string companyName, int wagePerHour, int totalWorkingDays, int totalWorkingHrs);

    }
}
