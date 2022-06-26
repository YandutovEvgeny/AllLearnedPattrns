using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13.Observer
{
    class ConcreteObserver : IObserver
    {
        public void Notify()
        {
            MessageBox.Show("Я за тобой слежу!");
        }
    }
}
