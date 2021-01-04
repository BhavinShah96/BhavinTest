using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Model
{
    class HoliRate : IFestivalRate
    {
        public double GetRate()
        {
            return 7;
        }
    }
}
