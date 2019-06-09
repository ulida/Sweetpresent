using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    class Program
    {
        public static void Main(string[] args)
        {
            Murshmallow murshmallow = new Murshmallow("Murshmallow", 4, 212.4,"vanillin");
            Chocolate chocolate = new Chocolate("Chocolate", 110, 512.2,"cocoa");
            Waffles waffles = new Waffles("Waffles set", 200, 413.6,"condenced milk");
            Biscuits biscuits = new Biscuits("Cookie", 60, 320, "souffle");
            Candy nuts = new Candy("Squerrel nuts", 11.2, 411, "nuts");
            Candy gelatin = new Candy("Jolly beans", 3.6, 210, "jelly");
            Candy lollipop = new Candy("Bim - bom", 4.1, 260, "caramel");
            Candy candymilk = new Candy("Nesquik", 90.2, 263, "milk");

            List<Sweet> Name = new List<Sweet>();
            {
                Name.Add(murshmallow);
                Name.Add(chocolate);
                Name.Add(waffles);
                Name.Add(biscuits);
                Name.Add(nuts);
                Name.Add(gelatin);
                Name.Add(lollipop);
                Name.Add(candymilk);
            }
            var sortedSweet = Name.OrderBy(x => x.Name);

            Console.ReadLine();                
        

        }
    }
    public class Sweet
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Calorie { get; set; }

        public Sweet(string _name, double _weight, double _calorie)
        {
            this.Name = _name;
            this.Weight = _weight;
            this.Calorie = _calorie;
            InfoSweet();
        }

        public void InfoSweet()
        {
            Console.WriteLine("");//Пустая строка, при выводе в консоль хорошо разделяет сладости. 
            Console.WriteLine("Name sweet of present: " + Name);
            Console.WriteLine($"Weight once sweet: {Weight} gramm");
            Console.WriteLine("Calories in 100 grams: " + Calorie);

        }
    }
    
}
