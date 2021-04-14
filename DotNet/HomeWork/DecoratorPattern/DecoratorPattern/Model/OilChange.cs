using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class OilChange : AdditionalBikeService
    {
        public OilChange(IBikeServices iBikeServices) : base(iBikeServices)
        {
            this.iBikeServices = iBikeServices;
        }

        public override double Cost()
        {
            return (iBikeServices.Cost() + 600.0);
        }

        public override string GetDescription()
        {
            return (iBikeServices.GetDescription() + "Oil Change");
        }
    }
}
