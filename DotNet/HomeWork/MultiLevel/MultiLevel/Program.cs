using MultiLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            BabyDog bbg = new BabyDog();
            bbg.Eat();
            bbg.Bark();
            bbg.Weep();
        }
    }
}
