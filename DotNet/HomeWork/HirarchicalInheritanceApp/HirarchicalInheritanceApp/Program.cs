using HirarchicalInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirarchicalInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
            BabyDog bbg = new BabyDog();
            bbg.Eat();
            bbg.Weep();
        }
    }
}
