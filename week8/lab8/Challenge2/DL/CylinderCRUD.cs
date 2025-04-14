using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2.DL
{
    class CylinderCRUD
    {
        public static List<Cylinder> cylinders = new List<Cylinder>();
        public static void AddCylinder(Cylinder cylinder)
        {
            cylinders.Add(cylinder);
        }

        public static List<Cylinder> GetAllCylinders()
        {
            return cylinders;
        }
    }
}
