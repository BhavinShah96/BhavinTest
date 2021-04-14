using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDemoApp.Model
{
    public interface IQueue <T>
    {
        void enqueue(T item);
        void dequeue();
        int count();
    }
}
