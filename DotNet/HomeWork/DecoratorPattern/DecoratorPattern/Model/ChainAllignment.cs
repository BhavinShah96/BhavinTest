using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class ChainAllignment : AdditionalBikeService
    {
        public ChainAllignment(IBikeServices iBikeServices) : base(iBikeServices)
        {
            this.iBikeServices = iBikeServices;
        }

        public override double Cost()
        {
            return (iBikeServices.Cost() + 500.0);
        }

        public override string GetDescription()
        {
            return (iBikeServices.GetDescription() + "Chain Allignment");
        }
    }
}
