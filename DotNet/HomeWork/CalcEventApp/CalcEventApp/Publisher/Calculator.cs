using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEventApp.Publisher
{

    public delegate void DCalcOperationAlert(int x, int y, int Answer);

    class Calculator
    {
        public int result;
        public event DCalcOperationAlert AdditionCompleted = null;
        public event DCalcOperationAlert SubstractionCompleted = null;

        public void Add(int x, int y)
        {
            if(AdditionCompleted != null)
            {
                AdditionCompleted(x, y, x + y);
            }
        }
        public void Sub(int x,int y)
        {
            if(SubstractionCompleted != null)
            {
                SubstractionCompleted(x, y, x - y);
            }
        }
    }
}
