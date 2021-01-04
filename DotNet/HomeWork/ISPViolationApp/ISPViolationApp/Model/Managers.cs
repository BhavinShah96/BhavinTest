using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Managers : IWokable
    {
        public void startWork()
        {
            Console.WriteLine("Manager is Working");
        }
        public void stopWork()
        {
            Console.WriteLine("Manager is not Working");
        }
        public void startEat()
        {
            Console.WriteLine("Manager is Eating");
        }
        public void stopEat()
        {
            Console.WriteLine("Manager is not Eating");
        }
    }
}
