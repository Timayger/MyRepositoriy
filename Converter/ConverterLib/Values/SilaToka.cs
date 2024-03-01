using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{    
    internal class SilaToka : IValue
    {
        private string _name = "Сила тока";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "Наноамперы",       0.000000001 },
            { "Микроамперы",      0.000001 },
            { "Милиамперы",       0.001 },
            { "Амперы",           1 },
            { "Килоамперы",       1000 }
        };
        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}
