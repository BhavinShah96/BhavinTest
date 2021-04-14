using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPetternAppDemo.Model
{
     public class RealSubject : Subject
    {
        public void PerformAction()
        {
            Console.WriteLine("RealSubject action Performed..");
        }
    }
}
