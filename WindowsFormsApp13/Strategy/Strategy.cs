using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Strategy
{
    //Позволяем менять воведение обьекта "на лету"
    class Strategy
    {
        ISomeAction _someAction;
        public Strategy()
        {
            _someAction = new Cleaning();
        }

        //ChangeAction(new Work());
        public void ChangeAction(ISomeAction someAction)
        {
            _someAction = someAction;
        }
        public string DoSomething()
        {
            return _someAction.DoSomething();
        }
    }
}
