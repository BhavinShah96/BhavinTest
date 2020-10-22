using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColorAndDateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodayDate();
            TextColor();
            Console.ReadKey();
        }
        public static void TextColor()
        {
            Console.WriteLine("Bhavin Shah");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bhavin Shah",Console.ForegroundColor);
        }
        public static void TodayDate()
        {
            Console.WriteLine(DateTime.Today.ToString("dd/MM/yyyy"));
        }
    }
}
