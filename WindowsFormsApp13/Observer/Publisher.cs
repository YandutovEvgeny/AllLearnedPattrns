using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Observer
{
    //Оповещает классы-наблюдатели о каком либо действии
    class Publisher
    {
        List<IObserver> _oservers;
        public Publisher()
        {
            _oservers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            _oservers.Add(observer);
        }
        public void DeleteObserver(IObserver observer)
        {
            _oservers.Remove(observer);
        }
        public void Notify()
        {
            foreach(IObserver observer in _oservers)
            {
                observer.Notify();
            }
        }
    }
}
