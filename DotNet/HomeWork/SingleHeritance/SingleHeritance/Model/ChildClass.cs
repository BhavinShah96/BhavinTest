using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleHeritance.Model
{
    class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is in Child Class Called");
        }
        public ChildClass(int foo) : base(foo)
        {
        }
    }
}
