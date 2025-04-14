using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2.DL
{
    class CircleCRUD
    {
        public static List<Circle> circles = new List<Circle>();
        public static void AddCircle(Circle circle)
        {
            circles.Add(circle);
        }

        public static List<Circle> GetAllCircles()
        {
            return circles;
        }
    }
}
