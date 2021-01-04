using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Game_App.Model
{
    public class Die
    {
        public int RandomNO()
        {
            Random random = new Random();
            int randomNo = random.Next(6) + 1;
            return randomNo;
        }
    }
}
