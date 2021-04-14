using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roll_die.Model
{
    class Dice
    {
        public int RandomNo()
        {
            System.Random random = new System.Random();
            int randomnum = 0;
            randomnum = random.Next(1, 6);

            return randomnum;
        }
    }
}
