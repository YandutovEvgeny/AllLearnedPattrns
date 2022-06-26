using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    //Позволяет  создавать ТОЛЬКО один обьект данного класса
    class Singletone
    {
        static  Singletone _singletone;
        private Singletone()
        {
            _singletone = new Singletone();
        }
        public static Singletone GetSingletone()
        {
            if (_singletone==null)
            {
                _singletone = new Singletone();
            }
            return _singletone;
        }
    }
}
