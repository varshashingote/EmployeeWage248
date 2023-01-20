using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage248
{

    internal class Program
    { 

        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        

        static void Main(string[] args)
        {
          
           //variable
            int empHrs = 0;
            int empWage = 0;
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
            
                  empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:"+empWage);

            Console.ReadLine();


        }
    }
}
