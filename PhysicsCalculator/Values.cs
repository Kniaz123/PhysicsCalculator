using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    public class Values
    {
        public enum TypeValue
        {
            Distance,
            Speed,
            Time
        }

        public Dictionary<string, string> DictionaryValue = new Dictionary<string, string>();

        public string Search(string SomeValue)
        {
            string str = null;
            foreach (KeyValuePair<string, string> kvp in DictionaryValue)
            {
                if (kvp.Key == SomeValue)
                {
                    str = kvp.Value;
                }
            }
            return str;
        }
    }
}
