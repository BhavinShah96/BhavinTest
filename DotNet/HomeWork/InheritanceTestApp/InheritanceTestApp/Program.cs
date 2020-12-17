using InheritanceTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTestApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ClassB onjb = new ClassB();
            Console.WriteLine("Addition is : " + onjb.Addition(10,20));
            Console.WriteLine("Substraction is : " + onjb.Substraction());
            
        }
    }
}
