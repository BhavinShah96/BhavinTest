using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcrudableApp.Model
{
    class AddressDB : Icrudable
    {
        public void create()
        {
            Console.WriteLine("Address DB is Created");
        }

        public void delete()
        {
            Console.WriteLine("Address DB is deleted");
        }

        public void read()
        {
            Console.WriteLine("Address DB is readed");
        }

        public void update()
        {
            Console.WriteLine("Address DB is updated");
        }
    }
}
