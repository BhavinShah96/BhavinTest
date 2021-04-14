using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemoApp.Model;

namespace FactoryPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutoMobile bmw = factory.Make(AutoType.BMW);
            bmw.Start();
            bmw.Stop();

            IAutoMobile audi = factory.Make(AutoType.AUDI);
            audi.Start();
            audi.Stop();

            AutoMobileFactory factory1 = new AutoMobileFactory();
            IAutoMobile tesla = factory1.Make(AutoType.TESLA);
            tesla.Start();
            tesla.Stop();
        }
    }
}
