using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolationApp.Model;

namespace DIPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate(LogType.JSON);
            Console.WriteLine(calc.CalculateTax(10,5));
            Console.WriteLine(calc.CalculateTax(0,0));
        }
    }
}
