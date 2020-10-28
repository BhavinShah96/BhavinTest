using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciSeriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i, n = 20;

            Console.WriteLine("Fibonacci Series" + val1);
            Console.Write(val1 + " " + val2 + " ");
            for (i = 2; i <= n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
            Console.ReadKey();
        }
    }
}
