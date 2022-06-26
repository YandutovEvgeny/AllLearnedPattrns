using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Memento
{
    class SomeClass
    {
        private string value1;
        private string value2;
        History history;

        public SomeClass(string v1, string v2)
        {
            value1 = v1;
            value2 = v2;
            history = new History();
        }

        public string DoSomething(SomeClassMemento someClass)
        {
            return someClass.Value1 + " " + someClass.Value2;
        }
        public void SaveToHistory(SomeClassMemento someClass)
        {
            history.ClassHistory.Push(someClass);
        }
        public SomeClassMemento LoadFromHistory()
        {
            return history.ClassHistory.Pop();
        }
    }
}
