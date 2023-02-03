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
            EmpWageBuiderObject dmart = new EmpWageBuiderObject("Dmart",20,2,10);
            EmpWageBuiderObject reliance = new EmpWageBuiderObject("Reliance",10,4,20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
            Console.ReadLine();
        }
    }
}
