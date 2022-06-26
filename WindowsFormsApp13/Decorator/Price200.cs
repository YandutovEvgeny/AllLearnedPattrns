using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Decorator
{
    class Price200 : AbstractDecorator
    {
        public Price200(DecoratorClass decorator) : base(decorator.Name + " с красивым бантиком", decorator) { }

        public override int GetPrice()
        {
            return _decorator.GetPrice() + 200;
        }
    }
}
