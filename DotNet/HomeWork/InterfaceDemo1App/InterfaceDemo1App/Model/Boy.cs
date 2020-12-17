using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1App.Model
{
    class Boy : IEmotionalize
    {
        public void cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }
    }
}
