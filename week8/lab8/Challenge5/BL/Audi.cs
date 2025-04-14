using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.BL
{
    class Audi : Car
    {
        int TurbosNo;
        public Audi(string modelName, int modelYear, string color, double price, int turbosNo) : base(modelName, modelYear, color, price)
        {
            TurbosNo = turbosNo;
        }
        public int GetTurbosNo()
        {
            return TurbosNo;
        }
        public bool SetTurbosNo(int turbosNo)
        {
            if(turbosNo < 0 || turbosNo > 4)
            {
                return false;
            }
            TurbosNo = turbosNo;
            return true;
        }
        public new double CalculateTax()
        {
            return Price * 0.12;
        }
    }
}
