using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTestApp.Model
{
    class ClassB : ClassA
    {
        int a = 10;
        int b = 20;

        public int Substraction()
        {
            return a - b;
        }
    }
}
