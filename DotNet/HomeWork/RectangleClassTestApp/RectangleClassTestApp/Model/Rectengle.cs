using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClassTestApp.Model
{
    public class Rectengle
    {
        private double height;
        private double width;

        public double getHeight()
        {
            return height;

        }
        public double getWidth()
        {
            return width;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }

        public void CalculateArea()
        {
            
            Console.WriteLine(" Area of Rectengle is :" + (width*height) );
        }
    }
}
