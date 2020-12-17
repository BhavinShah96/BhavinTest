using CandidateTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate c1 = new Candidate();
            c1.Id = 1;
            c1.Name = "Bhavin";
            c1.CreditPoint = "A";

            Candidate c2 = new Candidate();
            c2.Id = 2;
            c2.Name = "Abhinav";
            c2.CreditPoint = "C";

            PrintCandidateInfo(c1);
            PrintCandidateInfo(c2);

            PrintWhoIsBatter(c1, c2);
        }
        public static void PrintCandidateInfo(Candidate c)
        {
            Console.WriteLine("\nID is : " + c.Id);
            Console.WriteLine("\nName is : " + c.Name);
            Console.WriteLine("\nCredit Point is : " + c.CreditPoint);
        }
        public static void PrintWhoIsBatter(Candidate c1, Candidate c2)
        {
            if(!c1.CreditPoint.Equals(c2.CreditPoint))
            {
                Console.WriteLine(c1.Name + " is Better then " + c2.Name);
            }
            else
            {
                Console.WriteLine(c2.Name + " is Better Then " + c1.Name);
            }

        }
    }
}
