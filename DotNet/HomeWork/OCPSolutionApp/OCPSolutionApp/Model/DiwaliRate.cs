using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Model;

namespace OCPSolutionApp.Model
{
    class DiwaliRate : IFestivalRate
    {
        public double GetRate()
        {
            return 5;
        }
    }
}
