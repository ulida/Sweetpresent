using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    public class Biscuits:Sweet
    {
        public string Topping { get; set; }
        public Biscuits(string _name, double _weight, double _calorie, string _topping) : base(_name, _weight, _calorie)
        {
            this.Topping = _topping;
            Console.WriteLine("Topping in candy is  " + _topping);
            
        }
    }
}
