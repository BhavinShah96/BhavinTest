using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectengleArrayOfObjectTestApp.Model
{
    class Rectengle
    {
        readonly int START_RANGE = 1;
        readonly int END_RANGE = 100;


        private int height;
        private int width;
        private string color;

        public double getHeight()
        {
            return height;

        }
        public double getWidth()
        {
            return width;
        }

        public string getColor()
        {
            return color;
        }
        public void setHeight(int height)
        {
            this.height = checkDimentions(height);
        }
        public void setWidth(int width)
        {
            this.width = checkDimentions(width);
        }

        public void setColor(string color)
        {
            this.color = checkColor(color);
        }

        public int checkDimentions(int val)
        {
            if (val < START_RANGE)
                return START_RANGE;
            else if (val > END_RANGE)
                return END_RANGE;
            else
                return val;
        }
        public string checkColor(string val)
        {
            if (val.ToLower() == "red")
            {
                return "Red";
            }
            else if (val.ToLower() == "blue")
            {
                return "Blue";
            }
            else if (val.ToLower() == "green")
            {
                return "Green";
            }
            else
                return "Black";
        }

        public int CalculateArea()
        {
            return ((width * height));
            
        }

        public int Perimeter()
        {
            return(2 * (height + width));
            
        }
    }
}
