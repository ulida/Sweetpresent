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
            Sweet Murshmallow = new Sweet("Murshmallow", 4, 212.4);
            Sweet Chocolate = new Sweet("Chocolate", 110, 512.2);
            Sweet Waffles = new Sweet("Waffles set", 200, 413.6);
            Sweet Biscuits = new Sweet("Cookie", 60, 320);

            Candy nuts = new Candy("Squerrel nuts", 11.2, 411, "nuts");
            Candy gelatin = new Candy("Jolly beans", 3.6, 210, "jelly");
            Candy lollipop = new Candy("Bim - bom", 4.1, 260, "caramel");
            Candy candymilk = new Candy("Nesquik", 90.2, 263, "milk");



            Console.ReadLine();

        }
    }
    public class Sweet
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double calorie { get; set; }

        public Sweet(string _name, double _weight, double _calorie)
        {
            this.name = _name;
            this.weight = _weight;
            this.calorie = _calorie;
            InfoSweet();
        }

        public void InfoSweet()
        {
            Console.WriteLine("");//Пустая строка, при выводе в консоль хорошо разделяет сладости. 
            Console.WriteLine("Name sweet of present: " + name);
            Console.WriteLine($"Weight once sweet: {weight} gramm");
            Console.WriteLine("Calories in 100 grams: " + calorie);

        }
    }
    public class Candy : Sweet
    {
        public string topping { get; set; }
        public Candy(string _name, double _weight, double _calorie, string _topping) : base(_name, _weight, _calorie)
        {
            this.topping = _topping;
            Console.WriteLine("Topping in candy is" + _topping);

        }

    }
}
