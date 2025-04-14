using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class MountainBike : Bicycle
    {
        int SeatHeight;
        public MountainBike(int seatHeight, int speed, int cadence, int gearCount) : base(cadence, gearCount, speed)
        {
            seatHeight = SeatHeight;
        }

        public void SetSeatHeight(int seatHeight)
        {
            SeatHeight = seatHeight;
        }

    }
}
