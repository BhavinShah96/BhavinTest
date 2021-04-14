using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public abstract class AdditionalBikeService : IBikeServices
    {
        protected IBikeServices iBikeServices;

        public AdditionalBikeService(IBikeServices iBikeServices)
        {
            this.iBikeServices = iBikeServices;
        }

        public override abstract String GetDescription();
    }
}
