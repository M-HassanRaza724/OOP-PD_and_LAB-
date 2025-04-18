using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.UI;

namespace Task4.BL
{
    class Circle : Shape
    {
        double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToStringArea()
        {
            return $"The shape is circle and area is: {CalculateArea()}";
        }
        public double GetRadius()
        {
            return Radius;
        }
        public void SetRadius(double radius)
        {
            Radius = radius;
        }

    }
}
