using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Strategy
{
    class Cleaning : ISomeAction
    {

        public string DoSomething()
        {
            return "Уборка квартиры";
        }
    }
}
