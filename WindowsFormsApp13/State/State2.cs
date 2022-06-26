using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13.State
{
    class State2 : IState
    {
        public void NextState(StateMainClass stateMainClass)
        {
            stateMainClass.State = new State1();
        }

        public void ShowInfo(StateMainClass stateMainClass)
        {
            MessageBox.Show("Дальше будет State1");
        }
    }
}
