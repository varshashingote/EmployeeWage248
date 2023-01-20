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
            int isPresent = 1;


            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int EmployeeAttendance = random.Next(0, 2);
            //Computation
            if (EmployeeAttendance == isPresent)
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
