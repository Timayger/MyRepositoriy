using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    internal class PhysicalQuantity
    {
        public string Name { get; set; }

        private Dictionary<string, double> CoefList = new Dictionary<string, double>();

        public PhysicalQuantity(string name, Dictionary<string, double> coefList)
        {
            Name = name;
            CoefList = coefList;
        }
    }
}
