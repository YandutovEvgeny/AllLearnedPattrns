using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Memento
{
    class SomeClassMemento
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public int Value3 { get; set; }
        public SomeClassMemento(string v1, string v2, int v3)
        {
            Value1 = v1;
            Value2 = v2;
            Value3 = v3;
        }
    }
}
