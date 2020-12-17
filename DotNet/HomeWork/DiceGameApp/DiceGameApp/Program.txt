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
        public static int turn = 0;
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int randomNo = random.Next(6) + 1;
            
            //int _score = randomNo;
            int TotalScoreNeed = 20;
            
            
            string key;
            turn = turn + 1;
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
                        Console.WriteLine("The Game is Over with Score " + _score + " At " + turn + " turn ");
                    }

                }
            }
            else
            {
                
                Console.WriteLine("Your Current Score is " + _score + " At " + turn + " turn ");
                if (_score < TotalScoreNeed) // TotalScoreNeed = 20
                {
                    Main(null);
                }
                else
                {
                    Console.WriteLine("The Game is Over with Score " + _score + " At " + turn + " turn ");
                }
            }



        }



    }
}
