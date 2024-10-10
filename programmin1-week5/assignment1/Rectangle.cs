using System;
using System.Reflection.Metadata;

namespace assignment1
{
	public class Rectangle
	{
		public double height;
        public double width;

        public Rectangle(double height , double width)
		{
			this.height = height;
			this.width = width;
		}
		public double CalculateArea()
		{
            return height * width;
		}
        public double CalculatePerimeter()
        {
            return 2 * (height + width);
        }

    }
}

