using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 2.56f;
            double c = 2.85;
            string d = "Bhavin";
            char e = 'd';
            bool f = true;

            PrintInfo(a);
            PrintInfo(b);
            PrintInfo(c);
            PrintInfo(d);
            PrintInfo(e);
            PrintInfo(f);
        }

        public static void PrintInfo(int a)
        {
            Console.WriteLine("Integer value is :" + a);
        }
        public static void PrintInfo(float b)
        {
            Console.WriteLine("Float Value is " + b);
        }
        public static void PrintInfo(double c)
        {
            Console.WriteLine("Double Value is " + c);
        }
        public static void PrintInfo(string d)
        {
            Console.WriteLine("String Value is " + d);
        }
        public static void PrintInfo(char e)
        {
            Console.WriteLine("Character Value is " + e);
        }
        public static void PrintInfo(bool f)
        {
            Console.WriteLine("Boolean Value is " + f);
        }
    }
}
