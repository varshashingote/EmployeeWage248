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
            int isPresent = 1;
            Console.WriteLine("Employee wage computation ");
            //UC1 EmployeeAttendance

            Random random = new Random();
            int EmployeeAttendance = random.Next(0, 2);
            if (EmployeeAttendance == isPresent) 
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();


        }
    }
}
