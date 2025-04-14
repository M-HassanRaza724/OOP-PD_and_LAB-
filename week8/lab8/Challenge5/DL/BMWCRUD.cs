using Challenge5.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.DL
{
    class BMWCRUD
    {
        public static List<BMW> bMWs = new List<BMW>();
        public static void AddCar(BMW bMW)
        {
            bMWs.Add(bMW);
        }
        public static void RemoveCar(string modelName, int modelYear)
        {
            foreach (BMW bMW in bMWs)
            {
                if (bMW.GetModelName() == modelName && bMW.GetModelYear() == modelYear)
                {
                    bMWs.Remove(bMW);
                    break;
                }
            }
        }
        public static List<BMW> GetAllCars()
        {
            return bMWs;
        }
        public static BMW GetCarByModel(string modelName, int modelYear)
        {
            foreach (BMW bMW in bMWs)
            {
                if (bMW.GetModelName() == modelName && bMW.GetModelYear() == modelYear)
                {
                    return bMW;
                }
            }
            return null;
        }
    }
}
