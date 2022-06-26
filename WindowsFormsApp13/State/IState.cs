using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.State
{
    interface IState
    {
        void NextState(StateMainClass stateMainClass);
        void ShowInfo(StateMainClass stateMainClass);
    }
}
