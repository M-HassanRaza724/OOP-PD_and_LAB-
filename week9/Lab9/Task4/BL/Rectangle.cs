using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    class Rectangle : Shape
    {
        double Height;
        double Width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }
        public override string ToStringArea()
        {
            return $"The shape is rectangle and area is: {CalculateArea()}";
        }
        public double GetHeight()
        {
            return Height;
        }
        public void SetHeight(double height)
        {
            Height = height;
        }
        public double GetWidth()
        {
            return Width;
        }
        public void SetWidth(double width)
        {
            Width = width;
        }
    }
}
