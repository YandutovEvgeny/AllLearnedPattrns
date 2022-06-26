using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Adapter
{
    class Meter
    {
        protected double _someValue;
        public Meter(double Val)
        {
            _someValue = Val;
        }
        public double GetValue()
        {
            return _someValue;
        }
    }
}
