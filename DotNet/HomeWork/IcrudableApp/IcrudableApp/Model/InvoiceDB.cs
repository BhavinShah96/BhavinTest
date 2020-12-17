using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcrudableApp.Model
{
    class InvoiceDB : Icrudable
    {
        public void create()
        {
            Console.WriteLine("Invoice DB is Created");
        }

        public void delete()
        {
            Console.WriteLine("Invoice DB is Deleted");
        }

        public void read()
        {
            Console.WriteLine("Invoice DB is readed");
        }

        public void update()
        {
            Console.WriteLine("Invoice DBS is Updated");
        }
    }
}
