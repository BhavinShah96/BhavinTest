using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoApp.Model
{
    class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla has stopped");
        }
    }
}
