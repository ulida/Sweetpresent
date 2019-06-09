using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    public class Biscuits:Sweet
    {
        private string View { get; set; }
        public Biscuits(string _name, double _weight, double _calorie, string _topping,string _view) : base(_name, _weight, _calorie, _topping)
        {
            this.View = _view;
            Console.WriteLine("Biscuit has the appearance : " + View);

        }
    }
}
