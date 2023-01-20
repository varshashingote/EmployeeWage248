using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage248
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //constants

            int EMP_RATE_PER_HOUR = 20;
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
           //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int EmpCheck = random.Next(0, 3);
            //Computation
            if (EmpCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (EmpCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:"+empWage);

            Console.ReadLine();


        }
    }
}
