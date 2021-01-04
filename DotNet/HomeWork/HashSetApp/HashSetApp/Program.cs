using System;
using System.Collections.Generic;


namespace HashSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHsah = new HashSet<string>();

            myHsah.Add("Bhavin");
            myHsah.Add("Nikunj");
            myHsah.Add("Surekhaben");
            myHsah.Add("Pankajbhai");
            Console.WriteLine("Elements of MyHash Table :");

            printInfo(myHsah);
            Console.WriteLine("Elements of MyHash Table after Removing Data :");
            myHsah.Remove("Nikunj");
            printInfo(myHsah);

            myHsah.Add("Aditi");
            Console.WriteLine("Elements of MyHash Table after Removing Data :");
            printInfo(myHsah);

        }

        public static void printInfo(HashSet<string> myHash)
        {
            foreach(var i in myHash)
            {
                Console.WriteLine(i);
            }
        }
    }
}
