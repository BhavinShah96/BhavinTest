using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPrimeUsingCommandLineArgumentsTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = int.Parse(args[i]);
               PrintEvenNo(arr);  
            }

            
            //PrintEvenNo(arr);
            //PrintOddNo(arr);
            //PrintPrimeNo(arr);
            //Console.ReadKey();
        }
        public static void PrintEvenNo(int[] arr)
        {

            Console.Write("Even Numbers are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");

                }
            }
            Console.WriteLine("\n");
        }

        public static void PrintOddNo(int[] arr)
        {

            Console.Write("Odd Numbers are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");

                }
            }
            Console.WriteLine("\n");
        }

        public static void PrintPrimeNo(int[] arr)
        {

            Console.Write("Prime Numbers are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 2;
                int p = 1;

                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }
                if (p == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
