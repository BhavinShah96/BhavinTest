using DecoratorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBikeServices iBikeServices = new OilChange(new ChainAllignment(new BasicBikeService()));

            Console.WriteLine(iBikeServices.GetDescription());
            Console.WriteLine(iBikeServices.Cost());
        }
    }
}
