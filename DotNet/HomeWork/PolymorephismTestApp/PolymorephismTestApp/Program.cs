using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorephismTestApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string url = "https://www.swabhavtechlabs.com?trainee=bhavin";
            FetchFromURL(url);
        }
      public static void FetchFromURL(string str)
        {
            
            string[] pos3 = str.Split('.');
            string[] pos2 = str.Split('?');

            
            
            string ans2 = pos3[1];
            Console.WriteLine("Company Name is " + ans2);
            string ans = pos2[pos2.Length - 1];
            Console.WriteLine("Trainee is " + ans);
        }
    }
}
