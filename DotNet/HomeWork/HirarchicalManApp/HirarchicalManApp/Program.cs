using HirarchicalManApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirarchicalManApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Men m = new Men();
            //m.Play();

            //Boy b = new Boy();
            //b.Play();

            //Men b1 = new Boy();
            //b1.Play();

            Case4();
            //AtThePark(new Boy());
        }
        public static void AtThePark(Men x)
        {
            Console.WriteLine("At the park");
            x.Play();
            
        }
        public static void Case4()
        {
            Object x;
            x = 10;
            Console.WriteLine(x);
            x = "Bhavin";
            Console.WriteLine(x);
            x = new Men();
            Console.WriteLine(x.ToString());
        }
    }
}
