using PersonApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(17, "", "Male", 70, 5.5f);
            p.Name = "Bhavin";
            p.Age = 18;
            p.Height = 5.7f;
            p.Weight = 70;
            p.Gender = "Male";
            PrintInfo(p);

        }
        public static void PrintInfo(Person p)
        {
            if (p.Name == "" || p.Name == string.Empty)
            {
                Console.WriteLine("Name is : Unknown");
            }
            else { Console.WriteLine("name is :" + p.Name); }

            if (p.Age < p.Start_Range)
            {
                Console.WriteLine("Age is :" + p.Start_Range);
            }
            else if (p.Age > p.End_Range)
            {
                Console.WriteLine("Age is :" + (p.End_Range - 1));
            }
            else { Console.WriteLine("Age is :" + p.Age); }


            Console.WriteLine("Gender is " + p.Gender);
            Console.WriteLine("Weight is :" + p.Weight);
            Console.WriteLine("Height is :" + p.Height);
        }
    }
}
