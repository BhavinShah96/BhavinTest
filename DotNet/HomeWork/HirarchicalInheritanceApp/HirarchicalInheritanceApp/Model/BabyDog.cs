using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirarchicalInheritanceApp.Model
{
    class BabyDog : Animal
    {
        public void Weep()
        {
            Console.WriteLine("Baby Dog is Weeping");
        }
    }

}
