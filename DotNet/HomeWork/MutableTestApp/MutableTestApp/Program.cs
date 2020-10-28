using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MutableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 10;
            int[] s = { 10, 20, 30 };
            
            MutableInt(no);
            MutableArray(s);
            Console.WriteLine(no);
            Console.WriteLine(s);
        }
        public static void MutableInt(int number)
        {
            number = 20;
        }
        public static void MutableArray(int[] sum)
        {
          for(int i = 0; i < sum.Length; i++)
            {
                sum[i] = 0;
                Console.WriteLine("Array[{0}]: {1}", i, sum[i]);
            }
        }
    }
}
