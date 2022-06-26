using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.FactoryMethod
{
    class FishCannedFood : CannedFood
    {
        public FishCannedFood(double weight):base("Рыбные консервы",weight)
        { }
        public override int GetPrice()
        {
            return (int)(Weight * 3);
        }
    }
}
