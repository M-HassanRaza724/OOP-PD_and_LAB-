using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.BL
{
    class BMW : Car
    {
        int TurbosNo;

        public BMW(string modelName, int modelYear, string color, double price,int turbosNo) :base(modelName, modelYear, color, price)
        {
            TurbosNo = turbosNo;
        }
       
        public int GetTurbosNo()
        {
            return TurbosNo;
        }
        public void SetTurbosNo(int turbosNo)
        {
            TurbosNo = turbosNo;
        }
        public new double CalculateTax()
        {
            return Price * 0.1;
        }
    }
}
