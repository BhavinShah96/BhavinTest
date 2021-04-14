using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaApp
{
    public delegate void DDoSomeThing(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
        }

        public static void SayHello(string Name)
        {
            Console.WriteLine( Name + " Say Hello..!");
        }

        public static void Case1()
        {
            Console.WriteLine("\nCase 1:\n");
            DDoSomeThing dSays;
            //Action<string> dSays;
            dSays = SayHello;
            dSays("Bhavin");
        }

        public static void messageWizard(DDoSomeThing fn)
        {

            fn("Bhavin");
        }

        public static void Case2()
        {
            Console.WriteLine("\nCase 2\n");
            messageWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous Function");
                Console.WriteLine("hello\t" + name);
            });
        }

        public static void Case3()
        {
            Console.WriteLine("\nCase 3\n");
            messageWizard((n) =>
            {
                Console.WriteLine("Lambda Function");
                Console.WriteLine("hello\t" + n);
            });
        }
    }
}
