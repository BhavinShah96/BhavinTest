using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEventDemoApp.Publisher
{
    public delegate void DCalcOperationAlert(int x, int y, int Ans);
    class Calculator
    {
        public event DCalcOperationAlert AdditionCompleted = null;
        public event DCalcOperationAlert Substract = null;
        public event DCalcOperationAlert Multiplication = null;
        public void Add(int x,int y)
        {
            if(AdditionCompleted != null)
            {
                AdditionCompleted(x, y, x + y);
            }
        }
        public void Sub(int x, int y)
        {
            if (Substract != null)
            {
                Substract(x, y, x - y);
            }
        }
        public void Mul(int x, int y)
        {
            if (Multiplication != null)
            {
                Multiplication(x, y, x * y);
            }
        }
    }
}
