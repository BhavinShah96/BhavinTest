using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager();
            Robots r = new Robots();
            IWorkEat[] ie = new IWorkEat[1];
            ie[0] = mg;
            IWork[] i = new IWork[1];
            i[0] = r;
            PrintInfo(ie, i);

        }
        public static void PrintInfo(IWorkEat[] ie ,IWork[] r)
        {
            foreach(var i in ie)
            {
                i.startWork();
                i.stopWork();
                i.startEat();
                i.stopEat();
            }
            foreach(var i in r)
            {
                i.startWork();
                i.stopWork();
            }
        }
    }
}
