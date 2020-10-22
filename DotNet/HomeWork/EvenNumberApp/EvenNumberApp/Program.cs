using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EvenNumbers are :");
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
