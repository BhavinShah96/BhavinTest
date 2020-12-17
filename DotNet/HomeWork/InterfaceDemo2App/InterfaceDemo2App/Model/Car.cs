using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2App.Model
{
    class Car : IMoveble
    {
        public void start()
        {
            Console.WriteLine("Car has been Started");
        }

        public void stop()
        {
            Console.WriteLine("Car has Stopped");
        }
    }
}
