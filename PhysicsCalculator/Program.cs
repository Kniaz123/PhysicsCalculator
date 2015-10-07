using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Values Calculator = new Values();

            Operators Speed = new Operators(120, Values.TypeValue.Speed.ToString());
            Operators Time = new Operators(360, Values.TypeValue.Time.ToString());
            Operators Distance1 = new Operators(100, Values.TypeValue.Distance.ToString());
            Operators Distance2 = new Operators(50, Values.TypeValue.Distance.ToString());

            Calculator.DictionaryValue.Add("Distance", "м");
            Calculator.DictionaryValue.Add("Speed", "м/c");
            Calculator.DictionaryValue.Add("Time", "c");

            Operators qwe = Distance1 + Distance2;
            Console.WriteLine(qwe.Value + Calculator.Search(qwe.Type));

            Operators qwe1 = Distance1 - Distance2;
            Console.WriteLine(qwe1.Value + Calculator.Search(qwe.Type));

            Operators NewDistance = Speed * Time;
            Console.WriteLine(NewDistance.Value + Calculator.Search(NewDistance.Type));

            Operators NewSpeed = Distance1 / Speed;
            Console.WriteLine(NewSpeed.Value + Calculator.Search(NewSpeed.Type));

        }
    }
}
