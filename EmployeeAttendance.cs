using System;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8,PART_DAY_HR=4, IS_FULL_TIME=0,IS_PART_TIME=1;
        int totalEmpWage = 0 , empHRS=0;
        Random random = new Random();
        public void EmployeeAttendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            
                Console.WriteLine("Employee is present");
          
            else
                Console.WriteLine("Employee is Absent");
        }
        public void CalculateEmpWage()
        {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                case IS_FULL_TIME:
                    empHRS = FULL_DAY_HR;
                    break;
                case IS_PART_TIME:
                    empHRS = PART_DAY_HR;
                    break;
                default:
                    empHRS = 0;
                    break;
                }
                totalEmpWage = WAGE_PER_HR * empHRS;
                Console.WriteLine(totalEmpWage);
        }

    }
}
