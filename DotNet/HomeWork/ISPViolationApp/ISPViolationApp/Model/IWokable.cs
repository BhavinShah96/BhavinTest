using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    interface IWokable
    {
        void startWork();
        void stopWork();
        void startEat();
        void stopEat();
    }
}
