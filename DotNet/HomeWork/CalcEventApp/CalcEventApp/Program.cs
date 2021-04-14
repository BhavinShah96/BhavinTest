using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcEventApp.Publisher;

namespace CalcEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.AdditionCompleted += PrintAdditionalDetails;
            c.SubstractionCompleted += PrintSubstractionDetails;
            c.Add(50, 70);
            c.Sub(30, 10);
        }
        
        public static void PrintAdditionalDetails(int x, int y, int Result)
        {
            Console.WriteLine("Addition of {0} and {1} is done..",x,y);
            Console.WriteLine("Result : " + Result);
        }

        public static void PrintSubstractionDetails(int x, int y, int Result)
        {
            Console.WriteLine("Substraction of {0} and {1} is done..", x, y);
            Console.WriteLine("Result : " + Result);
        }

    }
}
