using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    
    public class Murshmallow : Sweet
    {
        private string Color { get; set; }
        public Murshmallow(string _name, double _weight, double _calorie, string _topping, string _color) : base(_name, _weight, _calorie, _topping)
        {
            this.Color = _color;
            Console.WriteLine("Color is " + Color);

        }
    }
}
