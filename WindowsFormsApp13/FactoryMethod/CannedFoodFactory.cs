using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.FactoryMethod
{
    //Создает обьекты, из заранее определенного переченья
    class CannedFoodFactory
    {
        // Второй способ реализации 
        List<CannedFood> Menu;
        public CannedFoodFactory(List<CannedFood> Menu)
        {
            this.Menu = Menu;
        }
        public CannedFood GetCannedFoodWithMenu(int num)
        {
            return Menu[num];
        }
        //******************************
        static CannedFood GetCannedFood(int type)
        {
            switch(type)
            {
                case 1: return new MeatCannedFood(0.5);
                case 2: return new MeatCannedFood(1);
                case 3: return new FishCannedFood(0.5);
                case 4: return new FishCannedFood(1);
                default: return new MeatCannedFood(0.5);
            }
        }
    }
}
