using InterfaceDemo1App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Men m = new Men();
            atTheMovie(m);
            atTheParty(m, m);

            Boy b = new Boy();
            atTheMovie(b);
        }

        private static void atTheMovie(IEmotionalize e)
        {
            Console.WriteLine("\n At the Movie :");
            Console.WriteLine("--------------");
            e.cry();
            e.laugh();
        }
        private static void atTheParty(IEmotionalize e,ISocialize s)
        {
            Console.WriteLine("\n At the Party :");
            Console.WriteLine("--------------");
            s.depart();
            s.wish();
            e.cry();
            e.laugh();
        }
    }
}
