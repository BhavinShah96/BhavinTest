using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoApp.Model
{
    class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("BMW has stopped");
        }
    }
}
