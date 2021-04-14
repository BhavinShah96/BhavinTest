using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPetternAppDemo.Model
{
    class RealClient : IClient
    {
        string Data;
        public RealClient()
        {
            Console.WriteLine("Real Client : Initialized.");
            Data = ".Net Tricks.";
        }
        public string GetData()
        {
            return Data;
        }
    }
}
