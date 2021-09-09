using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
           //Use Case 1: Check Employee is present or absent
            UC1_EmployeeAttendance.GetAttendance();


            //Use Case 2: Calculate Daily Employee Wage
            // UC2_DailyEmployeeWage.GetEmployeeWage();

            //Use Case 3: Calculate part time wages of an employee
            // UC3_PartTimeEmpWage.PartTimeEmpWage();

            //Use Case 4: Calculate employee wage using Switch cases
            // UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();

            //Use Case 5: Calculate monthly wages if working days are 20
            // UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();

            //Use Case 6: Calculate wage till 100hrs or 20 days reached
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
           

            //Use Case 7: Calculate employee wage using Class method
            // UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();

            //Use Case 8: Calculate employee wages for parsed values inside class method
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Microsoft",100,22,160);
            Console.ReadKey();
        }
    }
}
