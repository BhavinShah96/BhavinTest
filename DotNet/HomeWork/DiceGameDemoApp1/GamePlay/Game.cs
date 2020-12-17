using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGame;

namespace GamePlay
{
    public class Game
    {
        private int _score;
        private int TotalScoreNeed = 20;
        public int Score { get; set; }
        public int turn = 0;
        public int n = 0;

        public void PlayGame()
        {
            string key;
            Console.WriteLine("Hold or Role (h/r)");
            key = Console.ReadLine();
            n = Dice.Roll();

            turn += 1;
            if (key.ToLower() == "r")
            {

                Console.WriteLine(n);
                if (n == 1)
                {
                    Score = 0;
                    Console.WriteLine("Your score is Lost and Score is " + Score + " and Attend at Turn " + turn);
                    PlayGame();
                }
                else
                {
                    Score += n;
                    if (Score < TotalScoreNeed) // TotalScoreNeed = 20
                    {
                        PlayGame();
                    }
                    else
                    {
                        Console.WriteLine("You Won the Game with Score " + Score + " and Attend at Turn " + turn);
                    }

                }
            }
            else
            {
                Console.WriteLine("Your Current Score is " + Score);
                if (Score < TotalScoreNeed) // TotalScoreNeed = 20
                {
                    PlayGame();
                }
                else
                {
                    Console.WriteLine("You Won the Game with Score " + Score + " and Attend at Turn " + turn);
                }
            }



        }
    }
}
