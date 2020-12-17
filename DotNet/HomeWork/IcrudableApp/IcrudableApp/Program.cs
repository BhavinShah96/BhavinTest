using IcrudableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Icrudable i = new AddressDB();
            Icrudable i1 = new CustomerDB();
            Icrudable i2 = new InvoiceDB();
            PrintInfo(i, i1, i2);
        }
        public static void PrintInfo(Icrudable i ,Icrudable i1,Icrudable i2)
        {
            i.create();
            i.read();
            i.update();
            i.delete();
            Console.WriteLine("---------------");
            i1.create();
            i1.read();
            i1.update();
            i1.delete();
            Console.WriteLine("---------------");
            i2.create();
            i2.read();
            i2.update();
            i2.delete();
        }
    }
}
