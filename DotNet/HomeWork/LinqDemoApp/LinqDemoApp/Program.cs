using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1(args);
            Case2(args);
            Case3(args);
            Case4(args);
        }

        public static void Case1(string[] args)
        {
            Console.WriteLine("\nCase1 : \n");
            IEnumerable<string> name = args;

            var SortedName = name.OrderBy(x => x);
                
            foreach (var n in SortedName)
            {
                Console.WriteLine(n);
            }
        }

        public static void Case2(string[] args)
        {
            Console.WriteLine("\nCase2 : \n");
            IEnumerable<string> name = args;

            var SortedName = name.OrderBy(x => x).Take(3);
                
            foreach (var n in SortedName)
            {
                Console.WriteLine(n);
            }
        }

        public static void Case3(string[] args)
        {
            Console.WriteLine("\nCase3 : \n");
            IEnumerable<string> name = args;

            var SortedName = name.OrderByDescending(x => x.Length).First();
            Console.WriteLine(SortedName);
        }

        public static void Case4(string[] args)
        {
            Console.WriteLine("\nCase4 : \n");
            IEnumerable<string> name = args;

            var contains = name.OrderBy(x => x);

            foreach(var r in contains)
            {
                if(r.Contains("a"))
                {
                    Console.WriteLine(r);
                }

            }


        }

    }
}
