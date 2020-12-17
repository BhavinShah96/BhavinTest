using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReffTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            PrintNumReff(ref number);
            Console.WriteLine(number);

            int number2 = 20;
            PrintOutReff(out number2);
            Console.WriteLine(number2);

            UserParams(1,2,3,4);
            UserParams(5,6,7);
            UserParams(8);
        }
        public static void PrintNumReff(ref int refParameter)
        {
            refParameter = 40;
            
        }
        public static void PrintOutReff(out int ReffParameter)
        {
            ReffParameter = 20;
        }
        public static void UserParams(params int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
}
