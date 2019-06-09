using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    class Candy:Sweet
    {
        private string Wrapper { get; set; }
        private string Color { get; set; }
        public Candy(string _name, double _weight, double _calorie, string _topping,string _wrapper, string _color) : base(_name, _weight, _calorie,_topping)
        {
            this.Wrapper = _wrapper;
            this.Color = _color;
            Console.WriteLine($"The candy is Packed in a {Color}, {Wrapper} package"); ; ;



        }
    }
}
