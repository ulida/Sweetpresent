using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    public class Chocolate:Sweet
    {
        private int Cocoa { get; set; }

        public Chocolate(string _name, double _weight, double _calorie, string _topping, int _cocoa ) : base(_name, _weight, _calorie, _topping)
        {
            this.Cocoa = _cocoa;
            Console.WriteLine("Сocoa content: " + _cocoa);


        }
        
    }
}
