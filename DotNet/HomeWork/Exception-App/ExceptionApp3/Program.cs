using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am in Main.."); 
            try
            {
                m1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Information :", e.ToString());
            }
        }
        private static void m1()
        {
            Console.WriteLine("I am in M1..");
            Main(null);
            m2();
        }
        private static void m2()
        {
            Console.WriteLine("I am in M2..");
        }
    }
}
