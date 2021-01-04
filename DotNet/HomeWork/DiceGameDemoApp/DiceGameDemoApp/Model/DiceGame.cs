using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGameDemoApp.Model;


namespace DiceGameDemoApp.Model
{
    public class DiceGame
    {
        private int _score = 0;
        private int TotalScoreNeed = 20;
        private int TotalScore = 0;
        
         
        public int turn = 0;
        public int n = 0;

        public void PlayGame()
        {
            TotalScore = _score;
            string key;
            Console.WriteLine("Hold or Role (h/r)");
            key = Console.ReadLine();
            n = Dice.Roll();

            
            if (key.ToLower() == "r")
            {

                Console.WriteLine(n);
                if (n == 1)
                {
                    TotalScore = TotalScore + _score;
                    _score = 0;
                    Console.WriteLine("Your Lost your turn Score and Score is " + _score + " And Total Score is "+ TotalScore);
                    PlayGame();
                }
                else
                {
                    
                    TotalScore =  _score;
                    _score = n + _score;
                    if (TotalScore < TotalScoreNeed) // TotalScoreNeed = 20
                    {
                        PlayGame();
                    }
                    else
                    {
                        Console.WriteLine("You Won the Game with Total Score " + TotalScore);
                    }

                }
            }
            else
            {
                
                Console.WriteLine("Your Current turn Score is " + _score + " and Total Score is " + TotalScore);
                _score = 0;
                if (TotalScore < TotalScoreNeed) // TotalScoreNeed = 20
                {
                    PlayGame();
                }
                else
                {
                    Console.WriteLine("You Won the Game with Total Score " + TotalScore);
                }
            }



        }

    }
}
