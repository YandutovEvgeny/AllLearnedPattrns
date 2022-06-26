using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Builder
{
    class MainClassBuinder2:MainClass
    {
        public MainClassBuinder2()
        {
            mainClass = new Adapter.MainClass(new Adapter.Meter(6));
            FirstValue = 15;
            SecondValue = "Метров";
            ThridValue = DateTime.Now;
        }
    }
}
