using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Decorator
{
    class Price100 : AbstractDecorator
    {
        public Price100(DecoratorClass decorator) : base(decorator.Name + " с бантиком", decorator) { }
        public override int GetPrice()
        {
            return _decorator.GetPrice() + 100;
        }
    }
}
