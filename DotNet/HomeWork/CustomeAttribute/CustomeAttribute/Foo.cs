using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeAttribute
{
    public class Foo
    {
        [NeedToReflector]
        public void M1()
        {

        }
        [NeedToReflector]
        public void M2()
        {

        }
        public void M3()
        {

        }
        [NeedToReflector]
        public void M4()
        {

        }

    }
}
