using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineCheckedExeptionApp.Model
{
    class OutofStockException : Exception
    {
        public OutofStockException(string message)
            : base(message)
        { }
    }
}
