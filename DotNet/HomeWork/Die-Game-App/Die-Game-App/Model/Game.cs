using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Die_Game_App.Model;

namespace Die_Game_App.Model
{
    public class Game
    {
        public static int turnScore = 0;
        public static int finalScore = 20;
        
        public static void Role(int totalScore,int turn)
        {
            Die d = new Die();
            int randomNo = d.RandomNO();

            
        }
        
    }
}
