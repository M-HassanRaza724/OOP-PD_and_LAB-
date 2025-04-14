using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge5.BL;

namespace Challenge5.DL
{
    class CarCRUD
    {
        public static List<Car> Cars = new List<Car>();
        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public static void RemoveCar(string modelName ,int modelYear)
        {
            foreach(Car car in Cars)
            {
                if (car.GetModelName() == modelName && car.GetModelYear() == modelYear)
                {
                    Cars.Remove(car);
                    break;
                }
            }
        }
        public static List<Car> GetAllCars()
        {
            return Cars;
        }
        public static Car GetCarByModel(string modelName, int modelYear)
        {
            foreach (Car car in Cars)
            {
                if (car.GetModelName() == modelName && car.GetModelYear() == modelYear)
                {
                    return car;
                }
            }
                return null;
        }
    }
}
