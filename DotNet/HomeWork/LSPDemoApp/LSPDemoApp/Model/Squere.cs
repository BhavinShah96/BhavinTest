using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPDemoApp.Model;

namespace LSPDemoApp.Model
{
    class Squere : Rectengle
    {
        private int _side;

        public Squere(int side) : base(side ,side)
        {
            _side = side;
        }

        public override int setWidth { set => base.setWidth = _side; }
        public override int setHeight { set => base.setHeight = _side; }

        public override int CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
