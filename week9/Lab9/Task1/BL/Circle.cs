using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Circle
    {
        protected double Radius = 1.0;
        protected string Color = "Red";

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle() { }

        public double GetRadius()
        {
            return Radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetRadius(double radius)
        {
            Radius = radius;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public virtual string ToString()
        {
            return $"Circle[Radius: {Radius}, Color: {Color}]";
        }
    }
}
