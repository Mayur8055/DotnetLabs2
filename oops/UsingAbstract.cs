using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public abstract class Shape 
    {
        public abstract void Draw(); 
    }
    public class circle : Shape
    {
        public float Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Circle drawn with radius " + this.Radius);
        }
    }

}
