using RectengleRefTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectengleRefTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectengle r1 = new Rectengle();
            
            r1.setHeight(20);
            r1.setWidth(10);
            Console.WriteLine("r1.HashCode is : " + r1.GetHashCode());

            Rectengle r2;
            r2 = r1;
            Console.WriteLine("r2.HashCode is :" + r2.GetHashCode());

            r2.setHeight(r2.getHeight() + 1);
            r2.setWidth(r2.getWidth() + 1);

            Console.WriteLine("r1.Height : " + r1.getHeight());
            Console.WriteLine("r1.Width : " + r1.getWidth());

            Console.WriteLine("r2.Height :" + r2.getHeight());
            Console.WriteLine("r2.Width : " + r2.getWidth());
        }
    }
}
