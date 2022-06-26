using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    // Позволяет создавать копии обьектов данного класса
    class Prototype 
    {
        int _firstValue;
        string _secondValue;
        DateTime _thridValue;
        public Prototype(int f, string s, DateTime t)
        {
            _firstValue = f;
            _secondValue = s;
            _thridValue = t;
        }
        public Prototype Clone()
        {
            return new Prototype(_firstValue, _secondValue, new DateTime
                (_thridValue.Year,
                _thridValue.Month,
                _thridValue.Day));
        }
    }
}
