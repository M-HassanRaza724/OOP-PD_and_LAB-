using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.DL
{
    class MountainBikeCRUD
    {
        public static List<MountainBike> bikes = new List<MountainBike>();
        public static void AddMountainBike(MountainBike bike)
        {
            bikes.Add(bike);
        }
        public static List<MountainBike> GetMountainBikes()
        {
            return bikes;
        }
    }
}
