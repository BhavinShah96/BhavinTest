using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;

            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time < 22)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
            Console.ReadKey();
        }
    }
}
