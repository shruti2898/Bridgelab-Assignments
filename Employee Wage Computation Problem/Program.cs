using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructDemo.FinalSolution;
using ConstructDemo.UC10;
using ConstructDemo.UC9;

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



            // #region UC9
            //  EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //   EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //  dMart.computeEmpWage();
            //  Console.WriteLine(dMart.toString());
            //  reliance.computeEmpWage();
            //  Console.WriteLine(reliance.toString());
            //  #endregion

            //  #region UC10
            //  EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //  empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //   empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //   empWageBuilder.computeEmpWage();
            //   #endregion


            #region FinalSolution
            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuild.computeEmpWage();
            #endregion
            Console.ReadKey();
        }
    }
}
