using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleHeritance.Model
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("This is in Parent Class Called");
        }

        private int foo;
        public ParentClass(int foo)
        {
            this.foo = foo;
        }
        public int getValue()
        {
            return foo;
        }
    }
}
