using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosePrincipleApp.Model;

namespace OpenClosePrincipleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fixedDeposite = new FixedDeposite(20120, "Bhavin", 25000, 2, FestivalType.Holi);
            fixedDeposite.SimpleInterest();
            PrintInfo(fixedDeposite);
        }
        public static void PrintInfo(FixedDeposite fd)
        {
            Console.WriteLine("Account No :" + fd.AccNo);
            Console.WriteLine("Account Name :" + fd.AccName);
            Console.WriteLine("Account Balance :" + fd.Principle);
            Console.WriteLine("Festival : " + fd.Festival);
            Console.WriteLine("Total Amount of Interest  :" + fd.Amount);
        }
    }
}
