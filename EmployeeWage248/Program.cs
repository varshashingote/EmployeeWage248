﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeWage248
{

    internal class Program
    {


       
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
      
        public static void computeEmpWage(String company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            //variable
            int empHrs = 0;
            int totalEmpHrs = 0;

            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays )
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
            int totalEmpWage = totalEmpHrs + empRatePerHour;
            Console.WriteLine("total Employee Wage" + totalEmpWage);
            Console.ReadLine();
        }
        public static void Main(String[] args)
        {
            computeEmpWage( "Infosys", 20,2,10);
            computeEmpWage("DMart", 10, 4, 20);
        }
    }
}
            

        


    

       
    


