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
        public string Topping { get; set; }

        public Sweet(string _name, double _weight, double _calorie, string _topping)
        {
            this.Name = _name;
            this.Weight = _weight;
            this.Calorie = _calorie;
            this.Topping = _topping;
            InfoSweet();
        }

        public void InfoSweet()
        {
            Console.WriteLine("");//Пустая строка, при выводе в консоль хорошо разделяет сладости. 
            Console.WriteLine("Name sweet of present: " + Name);
            Console.WriteLine($"Weight once sweet: {Weight} gramm");
            Console.WriteLine("Calories in 100 grams: " + Calorie);
            Console.WriteLine("Topping in candy is " + Topping);

        }
    }
}
