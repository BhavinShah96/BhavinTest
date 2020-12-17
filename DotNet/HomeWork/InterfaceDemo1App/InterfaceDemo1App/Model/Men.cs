using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1App.Model
{
    class Men : IEmotionalize, ISocialize
    {
        public void cry()
        {
            Console.WriteLine("Men is Crying");
        }

        public void depart()
        {
            Console.WriteLine("Men is Departing");
        }

        public void laugh()
        {
            Console.WriteLine("Men is Laughing");
        }

        public void wish()
        {
            Console.WriteLine("Men is Wishing");
        }
    }
}
