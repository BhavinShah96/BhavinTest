using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employee = new List<string>();
            employee.Add("bhavin");
            employee.Add("aakash");
            employee.Add("ravan");
            employee.Add("Savanp");
            employee.Add("Surekha");

            char ch = 'a';

            // case 1
            IEnumerable<string> name = employee;


            foreach (var r in employee)
            {
                int count = r.Count(t => (t == ch));
                if (count >= 2)
                {
                    Console.WriteLine(r);
                }

            }

            // case 2
            Console.WriteLine("\n Case 2 :\n");
            var sortName = name.OrderByDescending(x => x);
            foreach (var r in sortName)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("\n Case 3 \n");
            var SortedName1 = name.OrderByDescending(x => x.Length).First();
            Console.WriteLine(" Largest Name :" + SortedName1);
            var SortedName2 = name.OrderBy(x => x.Length).First();
            Console.WriteLine(" Smallest : " +SortedName2);

            Console.WriteLine("\n Case 4 : \n");
            foreach (var r in name)
            {
                if (r.Contains("a") || r.Contains("e") || r.Contains("i") || r.Contains("o") || r.Contains("u") || r.Contains("A") || r.Contains("E") || r.Contains("I") || r.Contains("O") || r.Contains("U"))
                {
                    Console.WriteLine(r);
                }

            }
        }




    }
}
