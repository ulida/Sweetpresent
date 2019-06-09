using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_gift
{
    public class BoxSweets
    {
        public double Weight { get; set; }
        public string Size { get; set; }
        public string Content { get; set; }
                
        public void InfoBox()
        {
            Console.WriteLine($"Size box is: {Size}, Weight box: {Weight} gramm, Content is: {Content}");
        }


    }
}
