using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.State
{
    class StateMainClass
    {
        public IState State { get; set; }

        public StateMainClass()
        {
            State = new State1();
        }

        public void NextState()
        {
            State.NextState(this);
        }
        public void ShowInfo()
        {
            State.ShowInfo(this);
        }
    }
}
