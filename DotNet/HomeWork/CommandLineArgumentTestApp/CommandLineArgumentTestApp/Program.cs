using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgumentTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                number[i] = int.Parse(args[i]);
                Console.Write(number[i] + " ");
            }
        }
    }
}
