using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandLineArgumentTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] num = new int[args.Length];
            //double[] num = new double[args.Length];
            //float[] num = new float[args.Length];
            char[] num = new char[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                num[i] = char.Parse(args[i]);
                Console.WriteLine(num[i]);
            }
        }
    }
}
