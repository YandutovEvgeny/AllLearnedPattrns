using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Memento
{
    class History
    {
        public Stack<SomeClassMemento> ClassHistory { get; set; }

        public History()
        {
            ClassHistory = new Stack<SomeClassMemento>();
        }
    }
}
