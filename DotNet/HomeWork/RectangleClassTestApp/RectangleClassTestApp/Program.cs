using RectangleClassTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectengle rectObj = new Rectengle();
            rectObj.setHeight(20);
            rectObj.setWidth(101);
            rectObj.CalculateArea();
            rectObj.setColor("gREEn");

            printInfo(rectObj);

            Console.WriteLine(rectObj.GetHashCode());

            //rectObj.CalculateArea();
        }
        public static void printInfo(Rectengle r)
        {
            Console.WriteLine("Width of rectengle is" + r.getWidth());
            Console.WriteLine("Height of rectengle is" + r.getHeight());
            Console.WriteLine("Color is :" + r.getColor());
            Console.WriteLine(r.GetHashCode());
        }
    }
}
