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

            List<Sweet> Namesweet = new List<Sweet>();
            {
                Namesweet.Add(murshmallow);
                Namesweet.Add(chocolate);
                Namesweet.Add(waffles);
                Namesweet.Add(biscuits);
                Namesweet.Add(nuts);
                Namesweet.Add(gelatin);
                Namesweet.Add(lollipop);
                Namesweet.Add(candymilk);
            }
            var sortedsweet = Namesweet.OrderBy(na => na.Name);
            
            Console.WriteLine("Assorted sweets: ");

            foreach (Sweet n in Namesweet)
            {
               Console.WriteLine("Sweet name: {0}, Weight: {1}",n.Name,n.Weight);
            }

            Console.ReadLine();                
        }
    }
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
