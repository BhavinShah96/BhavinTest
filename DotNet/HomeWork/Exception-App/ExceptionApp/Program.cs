using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                int c = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can not divide any value using 0 \n" + e.ToString());
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index Out of Range Exception \n" + e.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Passing argument is not same as given Formate \n" + e.ToString());
            }
        }
    }
}
