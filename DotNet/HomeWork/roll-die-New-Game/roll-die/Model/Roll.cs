using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roll_die.Model
{
    class Roll
    {     
        public int RollDice(int ThisTurnScore)
        {
            Dice d = new Dice();

            int randomNo = d.RandomNo();
            Console.WriteLine(randomNo);

            if(randomNo == 1)
            {
                ThisTurnScore = 0;
            }
            else
            {
                ThisTurnScore += randomNo;
            }
            return ThisTurnScore;
        }
    }
}
