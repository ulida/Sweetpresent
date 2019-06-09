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
            Murshmallow murshmallow = new Murshmallow("Murshmallow", 4, 212.4, "vanillin", "pink");
            Chocolate chocolate = new Chocolate("Chocolate", 110, 512.2, "cocoa", 72);
            Waffles waffles = new Waffles("Waffles set", 200, 413.6, "condenced milk", 2);
            Biscuits biscuits = new Biscuits("Cookie", 60, 320, "souffle", "circle");
            Candy nuts = new Candy("Squerrel nuts", 11.2, 411, "nuts", "paper", "yellow");
            Candy gelatin = new Candy("Jolly beans", 3.6, 210, "jelly", "plastic", "red");
            Candy lollipop = new Candy("Bim - bom", 4.1, 260, "caramel", "paper", "multicolored");
            Candy candymilk = new Candy("Nesquik", 90.2, 263, "milk", "plastic", "red");

            List<Sweet> Present = new List<Sweet>();
            {
                Present.Add(murshmallow);
                Present.Add(chocolate);
                Present.Add(waffles);
                Present.Add(biscuits);
                Present.Add(nuts);
                Present.Add(gelatin);
                Present.Add(lollipop);
                Present.Add(candymilk);

                var sum = Present.Sum(value => value.Weight);
                Console.WriteLine("\nTotal weight present:" + sum);

                var sortedsweet = Present.OrderBy(value => value.Name).ToList();

                Console.WriteLine("\nAssorted sweets: ");

                foreach (Sweet n in sortedsweet)
                {
                    Console.WriteLine("\nSweet name: {0}, Weight: {1}", n.Name, n.Weight);
                }

                Sweet found = Present.Find(value => value.Name == "Chocolate");
                              
                Console.WriteLine("Result of search:\nSweet name: {0},\n Weight: {1},\n Calorie: {2} ", found.Name, found.Weight, found.Calorie);
                                
            }
            Console.ReadLine();

           
        }                                                         
    }
}   
    

