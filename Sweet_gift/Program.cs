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
                
                var sortedsweet = Namesweet.OrderBy(na => na.Name).ToList();

                Console.WriteLine("Assorted sweets: ");

                foreach (Sweet n in Namesweet)
                {
                    Console.WriteLine("Sweet name: {0}, Weight: {1}", n.Name, n.Weight);
                }
            }

            BoxSweets boox = new BoxSweets();
            boox.Content = "murshmalow";
            boox.Size = "small";
            boox.Weight = 600;
            boox.InfoBox();

            Console.ReadLine();                
        }
    }
    
}
