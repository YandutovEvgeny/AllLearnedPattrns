using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.FactoryMethod
{
    class MeatCannedFood : CannedFood
    {
        public MeatCannedFood(double weight) : base("Мясны консервы", weight)
        { }
        public override int GetPrice()
        {
            return (int)(Weight * 5);
        }
    }
}
