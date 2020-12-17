using InterfaceDemo2App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2App
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoveble i = new Truck();
            IMoveble i1 = new Car();
            IMoveble i2 = new Bike();
            PrintInfo(i,i1,i2);
        }
        public static void PrintInfo(IMoveble i,IMoveble i1,IMoveble i2)
        {
            i.start();
            i.stop();
            i1.start();
            i1.stop();
            i2.start();
            i2.stop();
        }
    }
}
