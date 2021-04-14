using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public abstract class IBikeServices
    {
        protected string description = "Unknown";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
