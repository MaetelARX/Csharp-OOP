using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * height + 2 * width;
        }
    }
}
