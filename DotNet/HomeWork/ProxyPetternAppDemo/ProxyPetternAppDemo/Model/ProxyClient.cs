using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPetternAppDemo.Model
{
    class ProxyClient : IClient
    {
        RealClient client = new RealClient();
        public ProxyClient()
        {
            Console.WriteLine("Proxy Client : Initialized.");
        }
        public string GetData()
        {
            return client.GetData();
        }

    }
}
