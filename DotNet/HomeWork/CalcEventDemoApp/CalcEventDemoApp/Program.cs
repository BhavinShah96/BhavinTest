using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcEventDemoApp.Publisher;

namespace CalcEventDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.AdditionCompleted += PrintDetails;
            c.Substract += PrintDetails;
            c.Multiplication += PrintDetails;
            c.Add(2, 3);
            c.Sub(25, 20);
            c.Mul(5, 5);
        }

        public static void PrintDetails(int x,int y,int Ans)
        {
            Console.WriteLine("\nAnswer of {0} and {1} is done...!",x,y);
            Console.WriteLine("Result : " + Ans);
        }
    }
}
