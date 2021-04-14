using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLatestDiceGame.Model
{
    class Dice
    {
        private int _value;

        

        public int RandomNo()
        {
            System.Random random = new System.Random();
            //int randomnum = 0;
            _value = random.Next(1, 6);
            return _value;
        }
        public int Value
        {
            get => _value;
        }

        public void Roll()
        {
            if(Value == 1)
            {

            }
        }

    }
}
