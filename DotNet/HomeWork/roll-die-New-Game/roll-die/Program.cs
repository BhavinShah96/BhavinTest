using roll_die.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roll_die
{
    class Program
    {
        static void Main(string[] args)
        {
            Roll r = new Roll();
            char input;
            int totalScore = 0, finalScore = 20, ThisTurnScore = 0, PrevTurnScore = 0,count = 1;

            while(totalScore < finalScore)
            {
                Console.WriteLine("\nTurn : " + count);
                Console.WriteLine("Rold or Hold ?");
                input = Convert.ToChar(Console.ReadLine().ToLower());

                if(input == 'r')
                {
                    ThisTurnScore = r.RollDice(ThisTurnScore);

                    if(ThisTurnScore == 0)
                    {
                        totalScore = PrevTurnScore;
                        Console.WriteLine("Turn Score : " + ThisTurnScore + "\nTotal Score : " + PrevTurnScore);
                        count++;
                    }
                    else
                    {
                        totalScore = PrevTurnScore + ThisTurnScore;
                    }
                }
                else if (input == 'h')
                {
                    Console.WriteLine("Turn Score : " + ThisTurnScore + "\nTotal Score : " + totalScore);
                    PrevTurnScore = totalScore;
                    ThisTurnScore = 0;
                    count++;
                }
            }
            if(totalScore >=20)
            {
                Console.WriteLine("Turn Score : " + ThisTurnScore + "\nTotal Score : " + totalScore + "\nTotal Turns Taken : " + count);
            }
        }
    }
}
