using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    class Square : Shape
    {
        double Side;

        public Square(double side)
        {
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
        public override string ToStringArea()
        {
            return $"The shape is square and area is: {CalculateArea()}";
        }
    }
}
