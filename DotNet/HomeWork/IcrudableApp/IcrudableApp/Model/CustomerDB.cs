using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcrudableApp.Model
{
    class CustomerDB : Icrudable
    {
        public void create()
        {
            Console.WriteLine("Customer DB is Created");
        }

        public void delete()
        {
            Console.WriteLine("Customer DB is deleted");
        }

        public void read()
        {
            Console.WriteLine("Customer DB is readed");
        }

        public void update()
        {
            Console.WriteLine("Customer DB is updated");
        }
    }
}
