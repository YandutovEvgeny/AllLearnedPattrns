using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Adapter
{
    // Позволяет приводить (адаптировать) один класс к другому
    class CentemetrsAdapter : Meter
    {
        public CentemetrsAdapter( Centimeter centimeter):base(0)
        {
            _someValue = centimeter.GetCentemetrs() / 100.0;
        }
    }
}
