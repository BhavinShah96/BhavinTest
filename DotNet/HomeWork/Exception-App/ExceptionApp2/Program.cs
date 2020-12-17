using System;
using System.Diagnostics;

namespace ExceptionApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                m1();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("New Exception is throwed.", e.ToString());
            }
        }
        static void m1()
        {
            Console.WriteLine("M1 is called");
            m2();
        }
        static void m2()
        {
            Console.WriteLine("M2 is called");
            m3();
        }
        static void m3()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame[] stackFrames = stackTrace.GetFrames();

            foreach (StackFrame stackFrame in stackFrames)
            {
                Console.WriteLine(stackFrame.GetMethod().Name);
            }
        }
    }
}
