using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameApp
{
    class Program
    {
        public static int _score = 0;
        public static int turn = 1;
        public static int TotalScore = 0;
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNo = random.Next(6) + 1;
            TotalScore = _score;
            //int _score = randomNo;
            int TotalScoreNeed = 20;


            string key;
            turn = turn++;
            Console.WriteLine("Turn :" + turn);
            Console.WriteLine("Hold or Role (h/r)");
            key = Console.ReadLine();



            if (key.ToLower() == "r")
            {

                Console.WriteLine(randomNo);
                if (randomNo == 1)
                {
                    _score = 0;
                    Console.WriteLine("You Lost all Score and Score is " + _score + " At " + turn + " turn \n");
                    turn = turn + 1;
                    Main(null);
                }
                else
                {

                    _score = randomNo + _score;

                    if (_score < TotalScoreNeed) // TotalScoreNeed = 20
                    {
                        Main(null);
                    }
                    else
                    {
                        Console.WriteLine("The Game is Over with Score " + _score + " in " + turn + " turn ");
                    }

                }
            }
            else
            {
                TotalScore = _score;
                Console.WriteLine("Your Current Score is " + TotalScore + " At " + turn + " turn ");

                if (TotalScore < TotalScoreNeed) // TotalScoreNeed = 20
                {

                    turn = turn + 1;
                    Main(null);
                }
                else
                {
                    Console.WriteLine("The Game is Over with Score " + TotalScore + " in " + turn + " turn ");
                }
            }



        }



    }
}
