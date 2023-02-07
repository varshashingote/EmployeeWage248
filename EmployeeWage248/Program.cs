using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage248
{
    class Program
    {
        static void Main(String[] args)
        {


            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart company :{0} ", empWageBuilder.getTotalWage("Dmart"));
            Console.WriteLine("Total Wage for Reliance company :{0} ", empWageBuilder.getTotalWage("Reliance"));
            Console.ReadLine();
        }
    }
}



