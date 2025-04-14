using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Bicycle
    {
        protected int Cadence;
        protected int     Gear;
        protected int     Speed;

        public Bicycle(int cadence, int gear, int speed)
        {
            Cadence = cadence;
            Gear = gear;
            Speed = speed;
        }

        public void SetCadence(int cadence)
        {
            Cadence = cadence;
        }
        public void SetGear(int gear)
        {
            Gear = gear;
        }
        public int GetCadence()
        {
            return Cadence;
        }
        public int GetGear()
        {
            return Gear;
        }
        public int GetSpeed()
        {
            return Speed;
        }

        public void SpeedUp(int increment)
        {
            Speed += increment;
        }

        public void ApplyBrake(int decrement)
        {
            Speed -= decrement;
        }
    }
}
