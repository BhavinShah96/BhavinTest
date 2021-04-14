using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonDemoApp.Model;

namespace SingleTonDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServices s1 = DataServices.getInstance();
            DataServices s2 = DataServices.getInstance();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            s1.processData();
            s2.processData();
        }
    }
}
