using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Adapter
{
    class Centimeter
    {
        int _sentemetrs;
        public Centimeter(int centemetrs)
        {
            _sentemetrs = centemetrs;
        }
        public int GetCentemetrs()
        {
         return   _sentemetrs;
        }
    }
}
