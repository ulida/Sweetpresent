using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
     public class Sweet
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Calorie { get; set; }
        public string Filling { get; set; }

        public Sweet(string _name, double _weight, double _calorie, string _filling)
        {
            this.Name = _name;
            this.Weight = _weight;
            this.Calorie = _calorie;
            this.Filling = _filling;
            InfoSweet();
        }

        public void InfoSweet()
        {
            Console.WriteLine("\nName sweet of present: " + Name);
            Console.WriteLine($"Weight one sweet: {Weight} gramm");
            Console.WriteLine("Calories in 100 gramm: " + Calorie);
            Console.WriteLine("Flling in sweets is " + Filling);

        }
    }
}
