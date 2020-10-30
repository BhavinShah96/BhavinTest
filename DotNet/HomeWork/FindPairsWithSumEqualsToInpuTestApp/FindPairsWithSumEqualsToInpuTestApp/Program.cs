using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FindPairsWithSumEqualsToInpuTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[args.Length];
            for(int i = 0; i < args.Length; i++)
            {
                array[i] = int.Parse(args[i]);
                
            }
            FindPairsWithSumEqualsToInput(array, 26);
        }

        //public static void FindPairsWithSumEqualsToInput(int[] array,int x)
        //{
        //    if(array.Length < 2)
        //    { return; }
        //    Console.WriteLine("The pairs Whoes Sum is Equal To Input No is :");

        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        for(int j = i +1 ; j < array.Length; j++)
        //        {
        //            int sum = array[i] + array[j];

        //            if(sum == x)
        //            {
        //                Console.WriteLine(array[i] + "," +array[j] );
        //            }
        //        }
        //    }
        //}

        public static void FindPairsWithSumEqualsToInput(int[] array, int x)
        {
            int cursum;

            if (array.Length < 2)
                { return; }
                //Console.WriteLine("The pairs Whoes Sum is Equal To Input No is :");

                for (int i = 0; i < array.Length; i++)
            {
                cursum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    //int sum = array[i] + array[j];

                    if (cursum == x)
                    {
                        int endIndexForCountArray = j - 1;
                        //Console.WriteLine("Sum found between indexes" + i + "and" + endIndexForCountArray);
                        for(int k = i; k <= endIndexForCountArray; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        return;
                    }
                    if (cursum > x || j == array.Length)
                        break;
                    cursum = cursum + array[j];
                }
            }
            Console.WriteLine("No Sub Array Found");
            return;
        }
    }
}
