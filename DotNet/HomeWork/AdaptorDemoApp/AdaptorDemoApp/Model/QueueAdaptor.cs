using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDemoApp.Model
{
    class QueueAdaptor<T> : IQueue<T>
    {
        private LinkedList<T> queue;

        public QueueAdaptor()
        {
            this.queue = new LinkedList<T>();
        }

        public  void enqueue(T item)
        {
            queue.AddLast(item);
        }
        public void dequeue()
        {
           queue.RemoveLast();
        }

        public int count()
        {
            return queue.Count();
        }

    }
}

