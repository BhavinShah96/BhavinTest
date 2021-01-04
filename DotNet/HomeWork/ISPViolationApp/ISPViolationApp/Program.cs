using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolationApp.Model;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers mg = new Managers();
            Robots r = new Robots();
            IWokable[] arr = new IWokable[2];
            arr[0] = mg;
            arr[1] = r;

            PrintInfo(arr);
        }
        public static void PrintInfo(IWokable[] arr)
        {
           foreach(var i in arr)
            {
                i.startWork();
                i.stopWork();
                i.startEat();
                i.stopEat();
                Console.WriteLine("\n");
            }
        }
    }
}
