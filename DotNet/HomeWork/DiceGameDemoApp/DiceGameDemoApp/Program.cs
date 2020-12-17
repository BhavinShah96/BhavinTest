using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGameDemoApp.Model;

namespace DiceGameDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceGame dc = new DiceGame();
            dc.PlayGame();
        }

    }
}
