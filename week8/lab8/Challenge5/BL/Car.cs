using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.BL
{
    class Car
    {
        protected string ModelName;
        protected int ModelYear;
        protected string Color;
        protected double Price;

        public Car(string modelName, int modelYear, string color, double price)
        {
            ModelName = modelName;
            ModelYear = modelYear;
            Color = color;
            Price = price;
        }
        public string GetModelName()
        {
            return ModelName;
        }
        public void SetModelName(string modelName)
        {
            ModelName = modelName;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public void SetModelYear(int modelYear)
        {
            ModelYear = modelYear; 
        }
        public string GetColor()
        {
            return Color;
        }
        public int GetModelYear()
        {
            return ModelYear;
        }
        public double GetPrice()
        {
            return Price;
        }
        public double CalculateTax()
        {
            return Price * 0.05;
        }

    }
}
