using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Decorator
{
    abstract class AbstractDecorator : DecoratorClass
    {
        protected DecoratorClass _decorator;
        public AbstractDecorator(string name, DecoratorClass decorator) : base(name)
        {
            _decorator = decorator;
        }
    }
}
