using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateDemoApp2
{
    public class Program
    {
        public delegate void DMathoperation(int a, int b);
        
        public static void Main(string[] args)
        {
            //Case1();
            Case2();
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition is :" + (a+b));
        }
        public static void Substract(int a,int b)
        {
            Console.WriteLine("Substraction is : " + (a-b));
        }
        public static void Multiplication(int a,int b)
        {
            Console.WriteLine("Multiplication is : " + (a*b));
        }
        public static void Devision(int a, int b)
        {
            Console.WriteLine("Devision is : " + (a/b));
        }
        public static void Case1()
        {
            Console.WriteLine("\nCase 1:\n");
            DMathoperation dMath;
            dMath = Add;
            dMath(20,50);
            dMath = Substract;
            dMath(50, 60);
            dMath = Multiplication;
            dMath(50, 30);
            dMath = Devision;
            dMath(20, 10);
        }

        public static void Case2()
        {
            
            DMathoperation[] d = new DMathoperation[4];
            d[0] = Add;
            d[1] = Substract;
            d[2] = Multiplication;
            d[3] = Devision;

            for (int i = 0; i < d.Length; i++)
            {
                d[i](20, 50);
            }
        }

    }
}
