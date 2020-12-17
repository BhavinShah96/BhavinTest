using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
        static void startGame()
        {
            System.Random random = new System.Random();

            Console.WriteLine("Enter any number between 1 and 100");

            int num;
            num = Convert.ToInt32(Console.ReadLine());

            int randomNum = random.Next(1, 100);

        }
    }
}
