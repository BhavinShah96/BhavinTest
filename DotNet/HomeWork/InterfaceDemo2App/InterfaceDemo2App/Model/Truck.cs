using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2App.Model
{
    class Truck : IMoveble
    {
        public void start()
        {
            Console.WriteLine("Truck has been Started");
        }

        public void stop()
        {
            Console.WriteLine("Truck has Stopped");
        }
    }
}
