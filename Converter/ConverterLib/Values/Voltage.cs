using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{    
    internal class Voltage : IValue
    {
        private string _name = "Электр. напряжение";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "Миливольты",       0.000000001 },
            { "Микровольты",      0.000001 },
            { "Нановольты",       0.001 },
            { "Вольты",           1 },
            { "Киловольты",       1000 },
            { "Мегавольты",       1000000 },
            { "Гигавольты",       1000000000 }
        };
        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}
