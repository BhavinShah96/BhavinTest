using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceOfApp2.Model
{
    class Boy : Men
    {
        public void Play()
        {
            Console.WriteLine("Boy is playing");
        }
        public void Eat()
        {
            Console.WriteLine("Boy is Eating");
        }
    }
}
