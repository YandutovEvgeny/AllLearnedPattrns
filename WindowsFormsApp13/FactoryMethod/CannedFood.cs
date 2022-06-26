using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.FactoryMethod
{
    abstract class CannedFood
    {
       public string Name { get; protected set; }
       public double Weight { get; protected set; }

       public CannedFood(string name, double weight)
       {
            Name = name;
            Weight = weight;
       }

      public  abstract int GetPrice();

    }
}
