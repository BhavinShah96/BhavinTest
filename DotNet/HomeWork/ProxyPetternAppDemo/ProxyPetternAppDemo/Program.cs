using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPetternAppDemo.Model;

namespace ProxyPetternAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyClient client = new ProxyClient();
            Console.WriteLine("Data from Proxy Client = {0}" , client.GetData());
            Console.ReadKey();
        }
    }
}
