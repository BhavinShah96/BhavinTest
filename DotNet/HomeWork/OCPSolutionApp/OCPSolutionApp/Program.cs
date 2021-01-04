using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Model;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fd = new FixedDeposite(20101, "Bhavin", 25000, 2, new DiwaliRate());
            Console.WriteLine(fd.SimpleInterest());
        }

        
    }
}
