using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoApp.Model
{
    class Rectengle
    {
        private int _width;
        private int _height;

        public Rectengle(int height,int width)
        {
            _height = height;
            _width = width;
        }

        public int getWidth { get => _width;}
        public virtual int setWidth { set => _width = value; }
        public  int getHeight { get => _height; }
        public virtual int setHeight { set => _height = value; }
        public virtual int CalculateArea()
        {
            return _height * _width;
        }

    }
}
