using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{
    internal class Volume : IValue
    {
        private string _name = "Объём";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "милилитры",      0.001 },
            { "литры",          1 },
            { "баррели",        158.99 },
            { "куб. метры",     1000 }
        };

        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}
