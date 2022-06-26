using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13.State
{
    class State1 : IState
    {
        public void NextState(StateMainClass stateMainClass)
        {
            stateMainClass.State = new State2();
        }

        public void ShowInfo(StateMainClass stateMainClass)
        {
            MessageBox.Show("Дальше будет State2");
        }
    }
}
