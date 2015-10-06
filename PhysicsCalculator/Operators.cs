using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    public class Operators
    {
        public int Value;
        public string Type;

        public Operators(int v, string t)
        {
            Value = v;
            Type = t;
        }

        public static Operators operator + (Operators element1, Operators element2)
        {
            if (element1.Type != element2.Type)
                throw new InvalidOperationException("Ошибка");
            return new Operators(element1.Value + element2.Value, element1.Type);            
        }

        public static Operators operator - (Operators element1, Operators element2)
        {
            if (element1.Type != element2.Type)
                throw new InvalidOperationException("Ошибка");
            return new Operators(element1.Value - element2.Value, element1.Type);
        }

        public static Operators operator * (Operators element1, Operators element2)
        {           
            if (
                (element1.Type != Values.TypeValue.Speed.ToString() || element1.Type != Values.TypeValue.Time.ToString())
                && (element2.Type != Values.TypeValue.Time.ToString() && element2.Type != Values.TypeValue.Speed.ToString())
                )
                throw new InvalidOperationException("Ошибка");
            return new Operators(element1.Value * element2.Value, Values.TypeValue.Distance.ToString());
        }

        public static Operators operator / (Operators element1, Operators element2)
        {
            string NewMessure=null;
            if (element1.Type == element2.Type || element1.Type!=Values.TypeValue.Distance.ToString())
                throw new InvalidOperationException("Ошибка");
            if (element1.Type == Values.TypeValue.Distance.ToString() && element2.Type == Values.TypeValue.Speed.ToString())
                NewMessure = Values.TypeValue.Time.ToString();
            if (element1.Type == Values.TypeValue.Distance.ToString() && element2.Type == Values.TypeValue.Time.ToString())
                NewMessure = Values.TypeValue.Speed.ToString();
            return new Operators(element1.Value / element2.Value, NewMessure );
        }
    }
}
