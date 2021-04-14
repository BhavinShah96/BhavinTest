using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoApp
{
    class Program
    {
        public delegate void DSays(string name);
        
        static void Main(string[] args)
        {
            //Case1();
            //Case2();
            //Case3();
            //Case4();
            //Case5();
            Case6();
            //Case7();
        }
        public static void Case1()
        {
            Console.WriteLine("\nCase 1:\n");
            DSays dSays;
            //Action<string> dSays;
            dSays = SayHello;
            dSays("Bhavin");
            dSays = SayGoodBy;
            dSays("Bhavin");

        }
        public static void Case2()
        {
            Console.WriteLine("\nCase 2:\n");
            DSays dSays;
            dSays = SayHello;
            dSays += SayGoodBy;
            dSays("Bhavin");
            
        }

        public static void SayHello(string name)
        {
             Console.WriteLine(name + " Says Hello ");
        }

        public static void SayGoodBy(string name)
        {
            Console.WriteLine(name + " Says Good Bye. ");
        }

        public static void messageWizard(DSays fn)
        {
           
            fn("Bhavin");
        }

        public static void Case3()
        {
            Console.WriteLine("\nCase 3\n");
            messageWizard(SayHello);
            messageWizard(SayGoodBy);
        }

        public static void Case4()
        {
            Console.WriteLine("\nCase 4\n");
            messageWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous Function");
                Console.WriteLine("hello\t" + name);
            });
        }

        public static void Case5()
        {
            Console.WriteLine("\nCase 5\n");
            messageWizard ( (n)=>
            {
                Console.WriteLine("Lambda Function");
                Console.WriteLine("hello\t" + n);
            });
        }

        public static string SayAnyThing(string fname,string lname)
        {
            Console.WriteLine(fname + " " + lname + " Says Something");
            return "";
        }
        public static void Case6()
        {
            Func<String,String,String> x;
            x = SayAnyThing;
            x("Bhavin","Shah");
        }

        public static Boolean FindEvenOdd(int no)
        {
            
            if (no % 2 == 0)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public static void Case7()
        {
            Predicate<int> x;
            x = FindEvenOdd;
            x(12);
        }
    }
}
