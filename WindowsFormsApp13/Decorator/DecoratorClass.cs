using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Decorator
{
    abstract class DecoratorClass
    {
        public string Name { get; set; }

        public DecoratorClass(string name)
        {
            Name = name;
        }

        public abstract int GetPrice();
    }
}
