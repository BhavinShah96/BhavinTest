using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectengleRefTestApp.Model
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
            if (height < 1)
            {
                this.height = 1;
            }
            else if (height > 100)
            {
                this.height = 100;
            }
            else
            {
                this.height = height;
            }
        }
        public void setWidth(double width)
        {
            if (width < 1)
            {
                this.width = 1;
            }
            else if (width > 100)
            {
                this.width = 100;
            }
            else
            {
                this.width = width;
            }
        }

        public void CalculateArea()
        {

            Console.WriteLine(" Area of Rectengle is :" + (width * height));
        }
    }
}
