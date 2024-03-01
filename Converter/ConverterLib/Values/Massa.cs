using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{
    internal class Massa : IValue
    {
        private string _name = "Масса";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "милиграммы",      0.000001 },
            { "граммы",          0.001 },
            { "килограммы",      1 },
            { "тонны",           1000 }
        };
        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}