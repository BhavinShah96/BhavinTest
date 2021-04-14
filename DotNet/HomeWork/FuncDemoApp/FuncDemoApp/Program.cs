using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            //Case2();
            Case3();
        }

        public static long Multiplication(int a,int b)
        {
            return a * b;
        }
        public static void Case1()
        {
            Func<int, int, long> x;
            x = Multiplication;
            Console.WriteLine("Multiplication is :" + x(12, 15)); 
        }

        public static void Case2()
        {

            Func<int, int, long> x;
            x = (delegate (int a, int b)
            {
                Console.WriteLine("In Anonymous Method");
                return a + b;
            });
            Console.WriteLine("Addition is : "+ x(10,20));
        }

        public static void Case3()
        {
            Func<int, int, int> x;
            x = ((a,b) => 
            {
                Console.WriteLine("Inside Lambda Function");
                return a * b;
            });
            Console.WriteLine("Multiplication is : " + x(10, 20));
        }
    }
}
