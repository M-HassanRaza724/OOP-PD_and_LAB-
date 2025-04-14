using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Cylinder : Circle
    {
        private double Height = 1.0;
        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            Height = height;
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }
        public Cylinder(double radius) : base(radius) { }
        public Cylinder() { }
        public double GetHeight()
        {
            return Height;
        }
        public void SetHeight(double height)
        {
            Height = height;
        }
        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
