using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameDemoApp.Model
{
    class Dice
    {
        public static int Roll()
        {
            Random random = new Random();
            int randomNo = random.Next(6) + 1;
            return randomNo;
        }
    }
}
