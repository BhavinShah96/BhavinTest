using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPDemoApp.Model;

namespace LSPDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectengle r = new Rectengle(30,20);
            

            Squere s = new Squere(30);

            Console.WriteLine(should_Not_Change_Width_If_Height_Change(r));
            Console.WriteLine(should_Not_Change_Width_If_Height_Change(s));
        }

        //public static void PrintInfo(Rectengle r)
        //{
        //    Console.WriteLine("Height = " + r.getHeight);
        //    Console.WriteLine("Width = " + r.getWidth);
        //    Console.WriteLine("Area = " + r.CalculateArea());
        //}

        public static bool should_Not_Change_Width_If_Height_Change(Rectengle r)
        {
            int before = r.getWidth;
            r.setHeight = r.getHeight + 10;
            int after = r.getHeight;
            if (before == after)
            {
                return true;
            }
            return false;
        }
    }
}
