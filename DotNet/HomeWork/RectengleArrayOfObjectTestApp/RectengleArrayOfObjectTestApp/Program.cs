using RectengleArrayOfObjectTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RectengleArrayOfObjectTestApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(new Rectengle().GetHashCode());
            //Console.WriteLine(new Rectengle().GetHashCode());
            //new Rectengle().setHeight(20);
            //new Rectengle().setWidth(50);
            //Console.WriteLine("Height : " + new Rectengle().getHeight() + " " + new Rectengle().GetHashCode());
            //Console.WriteLine("Width :" + new Rectengle().getWidth());

            Rectengle[] rectengle = new Rectengle[3];

            Rectengle r1 = new Rectengle();
            r1.setHeight(30);
            r1.setWidth(50);
            r1.setColor("Red");
            //Console.WriteLine(r1.GetHashCode());

            Rectengle r2 = new Rectengle();
            r2.setHeight(20);
            r2.setWidth(40);
            r2.setColor("Green");
            //Console.WriteLine(r2.GetHashCode());

            rectengle[0] = new Rectengle();
            rectengle[0].setHeight(2);
            rectengle[0].setWidth(80);

            rectengle[1] = r1;
            rectengle[2] = r2;
            //printInfo(rectengle);
            FindLargestWidthRectengle(rectengle);
            FindLargestPerimeterRectengle(rectengle);
            FindSmallestAreaOfRectengle(rectengle);
        }
        //public static void printInfo(Rectengle[] rec)
        //{
        //    for (int i = 0; i < rec.Length; i++)
        //    {
        //        Console.WriteLine("Output of Rectengle" + i);
        //        Console.WriteLine("Height: " + rec[i].getHeight());
        //        Console.WriteLine("Width: " + rec[i].getWidth());
        //        rec[i].CalculateArea();
        //        Console.WriteLine("Hash Code of rec " + i + " : " + rec[i].GetHashCode());
        //    }
        //}
        public static void FindLargestWidthRectengle(Rectengle[] rec)
        {
            if (rec[0].getWidth() > rec[1].getWidth() && rec[0].getWidth() > rec[2].getWidth())
            {
                Console.WriteLine(" The Largest Width is :" + rec[0].getWidth());
            }
            else if (rec[1].getWidth() > rec[2].getWidth())
            {
                Console.WriteLine(" The Largest Width is :" + rec[1].getWidth());
            }
            else
                Console.WriteLine(" The Largest Width is :" + rec[2].getWidth());
            
        }


        public static void FindLargestPerimeterRectengle(Rectengle[] rec)
        {
            if (rec[0].Perimeter() < rec[1].Perimeter() && rec[0].Perimeter() < rec[2].Perimeter())
            {
                Console.WriteLine(" The Largest Perimeter is :" + rec[0].Perimeter());
            }
            else if (rec[1].Perimeter() < rec[2].Perimeter())
            {
                Console.WriteLine(" The Largest Perimeter is :" + rec[1].Perimeter());
            }
            else
                Console.WriteLine(" The Largest Perimeter is :" + rec[2].Perimeter());
        }

        public static void FindSmallestAreaOfRectengle(Rectengle[] rec)
        {
            
                if (rec[0].CalculateArea() < rec[1].CalculateArea() && rec[0].CalculateArea() < rec[2].CalculateArea())
                {
                    Console.WriteLine(" The Smallest Area is :" +" "+ rec[0].CalculateArea());
                }
                else if (rec[1].CalculateArea() < rec[2].CalculateArea())
                {
                    Console.WriteLine(" The Smallest Area is :" +" "+rec[1].CalculateArea());
                }
                else
                    Console.WriteLine(" The Smallest Area is :" +" "+rec[2].CalculateArea());
            

        }
    }
}
