using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Robots : IWokable
    {
        public void startWork()
        {
            Console.WriteLine("Robot is Working");
        }
        public void stopWork()
        {
            Console.WriteLine("Robot is not Working");
        }
        public void startEat()
        {
            Console.WriteLine("Is Robot Eating?");
        }
        public void stopEat()
        {
            Console.WriteLine("Is Robot Eating??");
        }
    }
}
