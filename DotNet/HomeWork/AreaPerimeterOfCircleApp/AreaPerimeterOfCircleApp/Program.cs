using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterOfCircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            int r;
            Console.WriteLine("Enter the Radius of Circle");
            r = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Area Of given radius is " + (pi*r*r) + "\n");

            Console.WriteLine("Perimeter of Circle is " + 2 * pi * r);
            Console.ReadKey();
        }
    }
}
