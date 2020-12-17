using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcrudableApp.Model
{
    interface Icrudable
    {
        void create();
        void read();
        void update();
        void delete();
    }
}
