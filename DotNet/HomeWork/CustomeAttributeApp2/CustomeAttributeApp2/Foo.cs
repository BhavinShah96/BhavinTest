using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeAttributeApp2
{
    public class Foo
    {
        [Test]
        public bool m1()
        {
            return true;
        }
        
        public bool m2()
        {
            return false;
        }

        [Test]
        public bool m3()
        {
            return true;
        }
    }
}
