﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTestApp.Model
{
    public class ClassA
    {



        int a;
        int b;
        public int Addition(int a, int b)
        {
            this.a = a;
            this.b = b;
            return a + b;
        }
    }
}
