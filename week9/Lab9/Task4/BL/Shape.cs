using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
        public virtual string ToStringArea()
        {
            return "Area: " + CalculateArea();
        }
    }
}
