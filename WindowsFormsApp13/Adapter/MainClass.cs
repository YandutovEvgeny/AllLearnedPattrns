using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Adapter
{

    // MainClass Mainclass = new MainClass(new CentemetrsAdapter(new Centimeter(142)));
    class MainClass
    {
        Meter _meter;
        public MainClass( Meter meter)
        {
            _meter = meter;
        }
        public string GetResult()
        {
            return "Ваш рост " + _meter.ToString()+" метров";

        }
    }
}
