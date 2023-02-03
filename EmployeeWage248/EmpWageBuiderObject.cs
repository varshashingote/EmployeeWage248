using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeWage248
{

    public class EmpWageBuiderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuiderObject(string company,int empRatePerHours,int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour= empRatePerHours;
            this.maxHoursPerMonth= maxHoursPerMonth;
            this.numOfWorkingDays = numOfWorkingDays;

        }
        public void computeEmpWage()
        {
            //variable
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();

                int EmpCheck = random.Next(0, 3);
                //Computation
                switch (EmpCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
             totalEmpWage = totalEmpHrs + this.empRatePerHour;
            Console.WriteLine("total Employee Wage for company :" + company + "is" + totalEmpWage);
        }
        public string toString()
        {
            return "Total emp Wage for Company:" + this.company + "is" + this.totalEmpWage;
        }        
    }
}
            

        


    

       
    


