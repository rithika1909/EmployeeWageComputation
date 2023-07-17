using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation");
            CompanyWage appleWage = new CompanyWage("Apple", 200, 20, 100);
            //employeeWage.EmployeeAttendance();
            appleWage.EmployeeAttendance();
            appleWage.CalculateEmpWage();
            CompanyWage amazonWage = new CompanyWage("Amazon", 100, 20, 100);
            amazonWage.EmployeeAttendance();
            amazonWage.CalculateEmpWage();
        }
    }
}
