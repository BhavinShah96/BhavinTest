using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2App.Model
{
    class Bike : IMoveble
    {
        public void start()
        {
            Console.WriteLine("Bike has been Started");
        }

        public void stop()
        {
            Console.WriteLine("Bike has Stopped");
        }
    }
}
