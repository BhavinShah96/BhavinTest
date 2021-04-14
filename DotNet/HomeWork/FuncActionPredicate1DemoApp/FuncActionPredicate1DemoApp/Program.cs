using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate1DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
        }



        public static void Case1()
        {
            Console.WriteLine("Case 1 : Func<string , int> \n");
            Func<string, int> x = NoOfVowels;
            Console.WriteLine("No of Vowels in Bhavin : {0}", x("BhAvIn"));
            //    x = (str) =>
            //    {
            //        int aCount = 0;
            //        for (int i = 0; i < str.Length; i++)
            //        {
            //            if (str[i] == 'a' || str[i] == 'A')
            //            {
            //                aCount++;
            //            }
            //        }
            //        return aCount;
            //    };
            //    Console.WriteLine("No of a in Bhavin : {0}", x("Bhavin"));

        }
        public static void Case2()
        {
            Console.WriteLine("\n Case 2 Action<int> \n");
            Action<int> limit = DisplayEvenNo;
            limit(20);
        }
        public static void Case3()
        {
            Console.WriteLine("\nCase 3 Predicate<bool> \n");
            Predicate<int> z = IsPrimeNo;
            int no = 2;
            Console.WriteLine("{0} is prime no : {1}", no,z(no));
            z = (num) =>
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            
        }
        public static int NoOfVowels(string str)
        {
            int vowel = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
            }
            return vowel;
        }

        public static void DisplayEvenNo(int limit)
        {
            Console.WriteLine("Even No till : {0}", limit);
            for (int i = 0; i < limit; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static Boolean IsPrimeNo(int No)
        {
           int isPrime = 0;
            Console.WriteLine("Prime No :", No);
            int m = No / 2;
            for (int i = 2; i <= m; i++)
            {
                if (No % i == 0)
                {
                    isPrime = 1;
                    break;
                }
            }
            if(isPrime == 0)
            {
                return true;
            }
            return false;
        }
    }
}
