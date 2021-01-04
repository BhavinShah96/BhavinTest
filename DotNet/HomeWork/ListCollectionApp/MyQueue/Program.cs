using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQue = new Queue<string>();

            myQue.Enqueue("c#");
            myQue.Enqueue("Asp.Net");
            myQue.Enqueue("Visual Basic");
            Console.WriteLine(myQue.Peek());
            Console.WriteLine(myQue.Dequeue());
            Console.WriteLine(myQue.Count);

        }
    }
}
