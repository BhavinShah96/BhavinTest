using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptorDemoApp.Model;

namespace AdaptorDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> i = new QueueAdaptor<int>();

            i.enqueue(10);
            i.enqueue(20);
            i.enqueue(30);

            Console.WriteLine(i.count());
            i.dequeue();
            i.dequeue();

            Console.WriteLine(i.count());

            i.enqueue(10);
            i.enqueue(20);

            
        }
    }
}
