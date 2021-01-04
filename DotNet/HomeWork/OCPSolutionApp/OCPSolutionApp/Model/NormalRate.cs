using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Model
{
    class NormalRate : IFestivalRate
    {
        public double GetRate()
        {
            return 4.5;
        }
    }
}
