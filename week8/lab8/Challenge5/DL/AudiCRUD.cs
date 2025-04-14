using Challenge5.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.DL
{
    class AudiCRUD
    {
        public static List<Audi> audis = new List<Audi>();
        public static void AddCar(Audi audi)
        {
            audis.Add(audi);
        }
        public static void RemoveCar(string modelName, int modelYear)
        {
            foreach (Audi audi in audis)
            {
                if (audi.GetModelName() == modelName && audi.GetModelYear() == modelYear)
                {
                    audis.Remove(audi);
                    break;
                }
            }
        }
        public static List<Audi> GetAllCars()
        {
            return audis;
        }
        public static Audi GetCarByModel(string modelName, int modelYear)
        {
            foreach (Audi audi in audis)
            {
                if (audi.GetModelName() == modelName && audi.GetModelYear() == modelYear)
                {
                    return audi;
                }
            }
            return null;
        }
    }
}
