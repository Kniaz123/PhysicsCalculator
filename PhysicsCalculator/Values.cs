using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    class Values
    {
        public enum TypeValue
        {
            Speed,
            Time,
            Distance
        }

        public Dictionary<string, string> DictionaryValue = new Dictionary<string, string>();
    }
}
