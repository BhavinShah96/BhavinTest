using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    class BasicBikeService : IBikeServices
    {
        public BasicBikeService()
        {
            description = "Basic Bike Service";
        }

        public override double Cost()
        {
            return 400.0;
        }
    }
}
