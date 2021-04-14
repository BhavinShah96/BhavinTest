using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTestApp
{
    struct Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            

            p1.x = 20;
            p1.y = 30;
            Console.WriteLine("Alter Modification Value of X: " + +p1.x + " and Y :" + p1.y);
            Mpoint(p1.x, p1.y);
            Console.WriteLine("Alter Modification Value of X: " + +p1.x + " and Y :" + p1.y);
        }
        public static void Mpoint(int x,int y)
        {
            x = 25;
            y = 35;
        }

    }
}
