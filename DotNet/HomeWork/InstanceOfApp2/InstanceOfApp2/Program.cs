using InstanceOfApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceOfApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Men mobj = new Men();
            mobj.Eat();
            mobj.Play();

            Boy bobj = new Boy();

            Console.WriteLine(bobj is Men);
            Console.WriteLine(bobj is Object);
            Console.WriteLine(mobj is Object);
        }
    }
}
