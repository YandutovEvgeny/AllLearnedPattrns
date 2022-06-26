using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Decorator
{
    class ConcreteDecorator : DecoratorClass
    {
        public ConcreteDecorator() : base("Подарок") { }

        public override int GetPrice()
        {
            return 50;
        }
    }
}
