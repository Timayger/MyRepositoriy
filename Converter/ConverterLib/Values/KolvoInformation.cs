using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib.Values
{
    internal class KolvoInformation : IValue
    {
        private string _name = "Количество информации";

        public string GetName()
        {
            return _name;
        }

        private Dictionary<string, double> _coefList = new Dictionary<string, double>()
        {
            { "Бит",       8 },
            { "Байт",      1 },
            { "Кбайт",     1024 },
            { "Мбайт",     1048576 },
            { "Гбайт",     1073741824 },
            { "Тбайт",     1099511627776 }
        };

        public Dictionary<string, double> GetCoefDict()
        {
            return _coefList;
        }
    }
}
