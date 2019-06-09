using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    public class Waffles:Sweet
    {
        private int Number { get; set; }
        public Waffles(string _name, double _weight, double _calorie, string _topping, int _number) : base(_name, _weight, _calorie, _topping)
        {
        this.Number = _number;
        Console.WriteLine("number of pieces per pack: " + _number);
        
        }

    }
}
