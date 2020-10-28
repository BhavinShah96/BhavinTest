using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            float number;
            Console.WriteLine("Enter The Number For Squre");
            number = Convert.ToInt32(Console.ReadLine());

            float Ans = number * number;
            Console.WriteLine("Squre of Given number is " +Ans);
            Console.ReadKey();
        }
    }
}
