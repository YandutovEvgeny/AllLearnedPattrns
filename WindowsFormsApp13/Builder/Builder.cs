using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Builder
{
    class Builder
    {
        MainClass mainClass;
        public Builder()
        {
            mainClass = new MainClass();
            mainClass.SomeValues = new List<string>();
            mainClass.SomeValues.Add("Иванов Иван");
            mainClass.SomeValues.Add("Сидоров Семен");
            mainClass.SecondValue = " под отчисление";

        }
        public MainClass GetClass()
        {
            return mainClass;
        }
    }
}
