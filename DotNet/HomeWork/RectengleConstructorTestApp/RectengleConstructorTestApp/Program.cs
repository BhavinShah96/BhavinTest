using RectengleConstructorTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectengleConstructorTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectengle rec = new Rectengle(35,40);

            Console.WriteLine(rec.width * rec.height);
        }
    }
}
