using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{
    internal class Moshnost : IValue
    {
        private string _name = "Мощность";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "Ватты",    1 },
            { "Кватты",   0.001 },
            { "Мватты",   0.000001 }
        };
        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}
